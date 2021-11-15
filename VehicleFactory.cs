using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string userInput)
        {
            switch (userInput)
            {
                
                case "4":
                    return new Car();
                case "3":
                    return new Trikes();
                default:
                    return new Car(" Is ready to drive");
            }
        }

        public static Vehicle GetAbstractVehicle(string userInput)
        {
            switch (userInput)
            {
                case "2":
                    return new Motorcycle();
                
                default:
                    return new BasicVehicle();
            }
        }

    }
}