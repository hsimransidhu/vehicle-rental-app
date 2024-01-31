using System;

/// <summary>
///  rental transaction for cars, inheriting from RentalTransaction.
/// </summary>
public class CarRental : RentalTransaction
{
    public string CustomerName { get; set; }
    public DateTime ReturnDate { get; set; }
    public Car RentedCar { get; set; }

    // calculating the expenses of the rental vehicles
    public override double CalculateRentalCost()
    {
        TimeSpan rentalPeriod = ReturnDate - RentStartDate;
        int totalDays = (int)rentalPeriod.TotalDays;
        return totalDays * RentedCar.RentalRate;
    }
}
