using System;

/// <summary>
///  rental transaction for trucks, inheriting from RentalTransaction.
/// </summary>
public class TruckRental : RentalTransaction
{
    public string CustomerName { get; set; }
    public DateTime ReturnDate { get; set; }
    public Truck RentedTruck { get; set; }

    //Method Overriding
    public override double CalculateRentalCost()
    {
        TimeSpan rentalTime = ReturnDate - RentStartDate;
        int totalDays = (int)rentalTime.TotalDays;
        return totalDays * RentedTruck.RentalRate;
    }
}
