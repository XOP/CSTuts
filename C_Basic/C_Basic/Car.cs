using System;
using C_Basic.Math;

namespace C_Basic
{
    public enum GearTypes
    {
        Manual = 0,
        Auto = 1,
        Mixed = 10
    };

    public class Car
    {
        public string Model;
        public string Gear;

        public int Speed;
        public int SpeedBoost;

        /// <summary>
        /// casting gear string to the enum 
        /// </summary>
        /// <returns>The value.</returns>
        /// <param name="gearName">Gear name.</param>
        public int GearValue (string gearName)
        {
            return (int)Enum.Parse(typeof(GearTypes), gearName);
        }

        public void PrintGear () 
        {
            // alternative casting
            // var gearType = (GearTypes)0;
            // var gearType = GearTypes.Manual.ToString();

            Console.WriteLine(String.Format( "Car Gear type is {0} / {1} in catalogue", Gear, GearValue(Gear) ));
        }

        public void PrintModel () 
        {
            Console.WriteLine("Car Model: " + Model);

            foreach (char ch in Model) {
                Console.WriteLine("Give me " + ch + "!");
            }
        }

        public void PrintTotalSpeed () 
        {
            var totalSpeed = Calculator.Add(Speed, SpeedBoost);

            Console.WriteLine("Total Speed: " + totalSpeed);
        }

        public void PrintYear ()
        {
            var random = new Random();
            var carYear = random.Next(2010, 2020);

            Console.WriteLine(String.Format("Issued year {0}, limited series", carYear)); 
        }
    }
}
