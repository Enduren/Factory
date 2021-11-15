using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Depending on the  tires you say, we will create a new vehicle for you:");
            Console.WriteLine($"How many tires do you want your vehicle to have?");

            var userInput = Console.ReadLine();

            IVehicle userVehicle = VehicleFactory.GetVehicle(userInput);

            userVehicle.Drive();

            
            Console.WriteLine(" How many tires?");
            var absInput = Console.ReadLine();

            var abstractVehicle = VehicleFactory.GetAbstractVehicle(absInput);
            abstractVehicle.Drive();
        }
    }
}