using System;
using System.Collections.Generic;
using System.Text;

using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            WheelCount = "2";
        }

        public override void Drive()
        {
            Console.WriteLine($"Your Motorcycle {GetType().Name} is ready to pick up and drive.");
        }
    }
}
