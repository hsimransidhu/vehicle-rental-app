using System;


/// <summary>
///  an abstract base class for rental transactions.
/// </summary>
public abstract class RentalTransaction
{
    public int TransactionId { get; set; }
    public DateTime RentStartDate { get; set; } // use dateTime to get and set the date and time
    public DateTime RentalEndDate { get; set; }

    public abstract double CalculateRentalCost();
}
