using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class Engine
    {
        public int Power { get; set; }
        public int Fuel { get; set; }

        public Engine(int power, int fuel)
        {
            Power = power;
            Fuel = fuel;
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Fuel => Engine.Fuel;

        public Vehicle(string type, string model, Engine engine)
        {
            Type = type;
            Model = model;
            Engine = engine;
        }

        public void Drive(int fuelLoss)
        {
            Engine.Fuel -= fuelLoss;  // Decrease the fuel by the specified amount
        }


            // Test the Vehicle class directly in a Main method or other code

    public static void Run()
        {
            // Create an engine with power 100 and fuel 200
            Engine engine = new Engine(100, 200);

            // Create a vehicle with type 'a', model 'b', and the above engine
            Vehicle vehicle = new Vehicle("a", "b", engine);

            // Drive the vehicle, reducing fuel by 100
            vehicle.Drive(100);

            // Output the remaining fuel
            Console.WriteLine(vehicle.Fuel);  // Output: 100
        }
    }
}
