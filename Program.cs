using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(1, "Lamborghini", "Urus", 2021, 80.0, 8);
        RentalAgency.AddVehicle(car);
        Truck truck = new Truck(2, "Chevorlet", "Colorado", 2018, 90.0, 9.5);
        RentalAgency.AddVehicle(truck);

         
        Vehicle jackCar = RentalAgency.Vehicles[0]; 
        if (jackCar is Car) // Check if the vehicle is a car
        {
            Car jackCars = (Car)jackCar;  
            string customerNameCar = "Jack Williams"; 
            DateTime startDateCar = DateTime.Now; // Start date of the rental  
            DateTime endDateCar = DateTime.Now.AddDays(5); // End date of the rental  
            RentalAgency.ProcessCarRental(jackCars, customerNameCar, startDateCar, endDateCar); // Process the car rental
        }

 
        Vehicle kimTruck = RentalAgency.Vehicles[1];  
        if (kimTruck is Truck) // Check if the vehicle is a truck
        {
            Truck kimTrucks = (Truck)kimTruck;  
            string customerNameTruck = "Kim Kardashian";  
            DateTime startDateTruck = DateTime.Now.AddDays(2);  
            DateTime endDateTruck = DateTime.Now.AddDays(10); // End date of the rental 
            RentalAgency.ProcessTruckRental(kimTrucks, customerNameTruck, startDateTruck, endDateTruck);  
        }


        RentalAgency.DisplayRentalHistory();
    }
}
