 
using System;
using System.Collections.Generic;
/// <summary>
/// Represents a static class for managing rental operations.
/// </summary>
public static class RentalAgency
{
    //using list here
    public static List<Vehicle> Vehicles { get; } = new List<Vehicle>();
    public static List<CarRental> CarRentals { get; } = new List<CarRental>();
    public static List<TruckRental> TruckRentals { get; } = new List<TruckRental>();

    public static void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }

    public static void ProcessCarRental(Car car, string customerName, DateTime startDate, DateTime endDate)
    {
        var rental = new CarRental
        {
            RentedCar = car,
            CustomerName = customerName,
            RentStartDate = startDate,
            ReturnDate = endDate
        };
        CarRentals.Add(rental);
    }

    public static void ProcessTruckRental(Truck truck, string customerName, DateTime startDate, DateTime endDate)
    {
        var rental = new TruckRental
        {
            RentedTruck = truck,
            CustomerName = customerName,
            RentStartDate = startDate,
            ReturnDate = endDate
        };
        TruckRentals.Add(rental);
    }

    public static void DisplayRentalHistory()
    {
        Console.WriteLine("Car Rentals:");
        Console.WriteLine("==============");
        foreach (var rental in CarRentals)
        {
            Console.WriteLine($"Customer: {rental.CustomerName}\nVehicle: {rental.RentedCar.Make} {rental.RentedCar.Model},\n" + 
                              $"Rental  Time Period: {rental.RentStartDate.ToShortDateString()} to {rental.ReturnDate.ToShortDateString()},\n" +
                              $"Cost: ${rental.CalculateRentalCost()}\n" + "------------------------");
        }

        Console.WriteLine("\nTruck Rentals:");
        Console.WriteLine("==============");
        foreach (var rental in TruckRentals)
        {
            Console.WriteLine($"Customer: {rental.CustomerName}\nVehicle: {rental.RentedTruck.Make} {rental.RentedTruck.Model},\n" +
                              $"Rental Time Period: {rental.RentStartDate.ToShortDateString()} to {rental.ReturnDate.ToShortDateString()},\n" +
                              $"Cost: ${rental.CalculateRentalCost()}\n" + "------------------------");
        }
    }
}
