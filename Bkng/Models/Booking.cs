using System;
using System.ComponentModel.DataAnnotations;
using Avalonia.Collections;
using ReactiveUI;

namespace Bkng.Models;

public class Booking: ModelBase
{
    private int _bookingId;
    private DateTimeOffset _bookingStartDate  = DateTimeOffset.Now;
    private DateTimeOffset _bookingEndDate  = DateTimeOffset.Now;
    private decimal _bookingCost;
    private readonly AvaloniaList<Guest> _bookingGuest;
    private readonly AvaloniaList<Room> _bookingRoom;

    [Key]
    public int BookingId
    {
        get => _bookingId;
        set => this.RaiseAndSetIfChanged(ref _bookingId, value);
    }

    public DateTimeOffset BookingStartDate
    {
        get => _bookingStartDate;
        set => this.RaiseAndSetIfChanged(ref _bookingStartDate, value);
    }

    public DateTimeOffset BookingEndDate
    {
        get => _bookingEndDate;
        set => this.RaiseAndSetIfChanged(ref _bookingEndDate, value);
    }

    public decimal BookingCost
    {
        get => _bookingCost;
        set => this.RaiseAndSetIfChanged(ref _bookingCost, value);
    }

    public AvaloniaList<Guest> BookingGuest
    {
        get => _bookingGuest;
        init => this.RaiseAndSetIfChanged(ref _bookingGuest, value);
    }

    public AvaloniaList<Room> BookingRoom
    {
        get => _bookingRoom;
        init => this.RaiseAndSetIfChanged(ref _bookingRoom, value);
    }

    public override Booking Clone()
    {
        return new Booking()
        {
            BookingId = BookingId,
            BookingStartDate = BookingStartDate,
            BookingEndDate = BookingEndDate,
            BookingCost = BookingCost
        };
    }
}