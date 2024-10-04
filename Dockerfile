# Use the official Microsoft .NET SDK image for .NET 8 to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the project file and all source files into the container
COPY . .

# Restore any dependencies
RUN dotnet restore

# Build the application in Release mode
RUN dotnet publish -c Release -o out

# Use the runtime image to run the app
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime

WORKDIR /app

# Copy the build output from the build stage
COPY --from=build /app/out .

# Set the entry point to run your .NET app
ENTRYPOINT ["dotnet", "Linq.dll"]
