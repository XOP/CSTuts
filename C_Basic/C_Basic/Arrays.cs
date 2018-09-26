using System;

namespace C_Basic
{
    class ArrayClass
    {
        public void Init()
        {

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            // int[] CarYears = new int[] { };

            // int array
            var CarYears = new int[4];

            CarYears[0] = 1980;

            Console.WriteLine(CarYears[0]);
            Console.WriteLine(CarYears[1]);
            Console.WriteLine(CarYears[2]);
            Console.WriteLine(CarYears[3]);

            // boolean array
            var CarWheels = new bool[4];

            CarWheels[0] = true;
            CarWheels[1] = true;

            Console.WriteLine(CarWheels[0]);
            Console.WriteLine(CarWheels[1]);
            Console.WriteLine(CarWheels[2]);
            Console.WriteLine(CarWheels[3]);

            // string array
            var CarAliases = new string[3] { "HorseForce", "Mustang", "Model-T" };
        }
    }
}
