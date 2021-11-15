using System;
using System.Collections.Generic;
using System.Text;

using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public Car(string input)
        {
            Console.WriteLine(input);
        }

        public void Drive()
        {
            Console.WriteLine($"Your car {GetType().Name} is ready.Lets Drive!!!!!");
        }
    }
}
