using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator.Net6;

public class Method
{
    public static void Exercise1()
    {
        var car1 = new Car();
        car1.Year = 1998;
        car1.Make = "Ford";
        car1.Model = "F-150";

        Console.WriteLine($"Year: {car1.Year}");
        Console.WriteLine($"Make: {car1.Make}");
        Console.WriteLine($"Year: {car1.Model}");

    }
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }


}
