using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryPatternExercise
{
    public class Trikes : IVehicle
    {
        public Trikes()
        {
          
        }

        public void Drive()
        {
            Console.WriteLine($"Your trike{GetType().Name} is ready Lets Goooo!!!!");
        }
    }
}
