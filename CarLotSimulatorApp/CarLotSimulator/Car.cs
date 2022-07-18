using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car 
    {
        public Car()
        {
            
        }

        public Car(int year, string model, string engineNoise, string honkNoise, bool isDrivable, string make)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; } = "Vroom";
        public string HonkNoise { get; set; } = "Beep!";
        public bool IsDrivable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }

}
