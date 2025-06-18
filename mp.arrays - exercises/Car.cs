using System;
using System.Collections.Generic;

class Car
{
    // Private fields
    private string brand;
    private string model;
    private int horsepower;

    // Constructor that takes only the brand
    public Car(string brand)
    {
        this.brand = brand;
        this.model = "unknown"; // Default to "unknown"
        this.horsepower = -1;   // Default to -1
    }

    // Constructor that takes all the fields
    public Car(string brand, string model, int horsepower)
    {
        this.brand = brand;
        this.model = model;
        this.horsepower = horsepower;
    }

    // Getters and setters for each field
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Horsepower
    {
        get { return horsepower; }
        set { horsepower = value; }
    }

    // CarInfo method to return car details in the desired format
    public string CarInfo()
    {
        return $"The car is: {brand} {model} - {horsepower} HP.";
    }

    // Run method to read input and display the information
    public static void Run()
    {
        int n = int.Parse(Console.ReadLine()); // Read the number of cars
        var cars = new List<Car>(); // List to store car objects

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split(); // Read each car's info

            if (carInfo.Length == 1)
            {
                // If there's only one element (brand), create the car with default model and horsepower
                string brand = carInfo[0];
                Car car = new Car(brand); // Use the constructor that takes only the brand
                cars.Add(car); // Add the car to the list
            }
            else if (carInfo.Length == 3)
            {
                // If there are three elements (brand, model, horsepower), create the car with full info
                string brand = carInfo[0];
                string model = carInfo[1];
                int horsepower = int.Parse(carInfo[2]);

                Car car = new Car(brand, model, horsepower); // Use the constructor that takes all fields
                cars.Add(car); // Add the car to the list
            }
        }

        // Print car info for each car in the list
        foreach (Car car in cars)
        {
            Console.WriteLine(car.CarInfo());
        }
    }
}