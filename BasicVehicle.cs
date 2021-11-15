using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryPatternExercise
{
    public class BasicVehicle : Vehicle
    {
        public BasicVehicle()
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"We dont have it in stock");
        }
    }
}
