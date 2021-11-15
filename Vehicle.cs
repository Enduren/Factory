using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryPatternExercise
{
    public abstract class Vehicle
    {
        public string WheelCount { get; set; }

        public abstract void Drive();

        public virtual void BasicDefault()
        {
            Console.WriteLine($"Im Sorry please try again");
        }
    }
}
