using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

class Car
{

    public string name { get; set; }
    public int age { get; set; }
    public string address { get; set; }

};

class Program
{
    static void Main()
    {
        var cars = new List<Car>
        {
             new() { name = "Mercedes", age = 13, address = "lk2" },
    new() { name = "BMW", age = 5, address = "k12" },
    new() { name = "Audi", age = 8, address = "m22" },
    new() { name = "Toyota", age = 10, address = "t15" },
    new() { name = "Ford", age = 6, address = "f45" },
    new() { name = "Honda", age = 7, address = "h99" },
    new() { name = "Volkswagen", age = 12, address = "v34" },
    new() { name = "Chevrolet", age = 9, address = "c78" },
    new() { name = "Hyundai", age = 3, address = "h23" },
    new() { name = "Nissan", age = 4, address = "n56" }
        };

        var newerCars= cars.Where(c=>c.age<5).ToList();
        foreach(var car in newerCars)
        {
            Console.WriteLine(car.name);
        }
        var carsDescendingOrder= cars.OrderByDescending(c=>c.age);
        foreach(var car in carsDescendingOrder) { Console.WriteLine(car.name); }


        Console.ReadKey();

        
    }
}