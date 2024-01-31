using System;

/// <summary>
///  a derived class for trucks, inheriting from Vehicle.
/// </summary>
public class Truck : Vehicle
{
    public double CargoCapacity { get; set; }

    public Truck(int vehicleId, string make, string model, int year, double rentalRate, double cargoCapacity)
        : base(vehicleId, make, model, year, rentalRate)
    {
        CargoCapacity = cargoCapacity;
    }
    // Display information about truck
    public void DisplayInfo()
    {
        Console.WriteLine($"Truck: {Make} {Model}, Year: {Year}, Rental Rate: ${RentalRate}/day, Cargo Capacity: {CargoCapacity} cubic meters");
    }
}
