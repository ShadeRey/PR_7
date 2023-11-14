using System;

namespace Bkng.Models;

public class Booking
{
    public int BookingId { get; set; }
    public DateTimeOffset? BookingStartDate { get; set; }
    public DateTimeOffset? BookingEndDate { get; set; }
    public decimal BookingCost { get; set; }
    public int BookingGuest { get; set; }
    public int BookingRoom { get; set; }
}