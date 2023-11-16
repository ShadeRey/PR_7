using System.ComponentModel.DataAnnotations;
using Avalonia.Collections;
using ReactiveUI;

namespace Bkng.Models;

public class Room: ModelBase
{
    private int _roomId;
    private decimal _roomPrice;
    private readonly AvaloniaList<RoomType> _roomType;
    private readonly AvaloniaList<Hotel> _roomHotel;

    [Key]
    public int RoomId
    {
        get => _roomId;
        set => this.RaiseAndSetIfChanged(ref _roomId, value);
    }

    public decimal RoomPrice
    {
        get => _roomPrice;
        set => this.RaiseAndSetIfChanged(ref _roomPrice, value);
    }

    public AvaloniaList<RoomType> RoomType
    {
        get => _roomType;
        init => this.RaiseAndSetIfChanged(ref _roomType, value);
    }

    public AvaloniaList<Hotel> Hotel
    {
        get => _roomHotel;
        init => this.RaiseAndSetIfChanged(ref _roomHotel, value);
    }

    public override Room Clone()
    {
        return new Room()
        {
            RoomId = RoomId,
            RoomPrice = RoomPrice
        };
    }
}