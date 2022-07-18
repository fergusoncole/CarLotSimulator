using System;
using System.Collections.Generic;
using CarLotSimulator;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carlot = new CarLot();
            carlot.ParkingLot = new List<Car>();

            Car car1 = new Car();
            car1.Make = "Mazda";
            car1.Model = "CX-5";
            car1.Year = 2016;
            car1.EngineNoise = "Zoooom";
            car1.IsDrivable = true;
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            carlot.ParkingLot.Add(car1);

            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberofCars}");
           
            Console.WriteLine($"\n\n");

                var car2 = new Car()
                {
                    Make = "Chevrolet",
                    Model = "Tahoe",
                    Year = 1998,
                    EngineNoise = "Shake, struggle...struggle",
                    HonkNoise = "Loud and proud Beep!",
                    IsDrivable = true

                };
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            carlot.ParkingLot.Add(car2);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberofCars}");
            Console.WriteLine($"\n\n");

            Car car3 = new Car(2005, "Grand Prix", "Purr", "Quiet beep", true, "Pontiac");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            carlot.ParkingLot.Add(car3);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberofCars}");
            Console.WriteLine($"\n\n");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            foreach (var car in carlot.ParkingLot)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make:{car.Make}");
                Console.WriteLine($"Model:{car.Model}");
                Console.WriteLine($"\n\n");
            }
        }
    }
}
