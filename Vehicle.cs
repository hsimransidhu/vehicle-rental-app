using System;
/// <summary>
/// a base class for vehicles.
/// </summary>
public class Vehicle
{
    public int VehicleId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double RentalRate { get; set; }

    public Vehicle(int vehicleId, string make, string model, int year, double rentalRate)
    {
        VehicleId = vehicleId;
        Make = make;
        Model = model;
        Year = year;
        RentalRate = rentalRate;
    }
}

/// <summary>
///  a derived class for cars, inheriting from Vehicle.
/// </summary>
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(int vehicleId, string make, string model, int year, double rentalRate, int numberOfDoors)
        : base(vehicleId, make, model, year, rentalRate)
    {
        NumberOfDoors = numberOfDoors;
    }
    // display information about car
    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Make} {Model}, Year: {Year}, Rental Rate: ${RentalRate}/day, Doors: {NumberOfDoors}");
    }
}

