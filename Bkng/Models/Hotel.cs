using System.ComponentModel.DataAnnotations;
using Avalonia.Collections;
using ReactiveUI;

namespace Bkng.Models;

public class Hotel: ModelBase
{
    private int _hotelId; 
    private string _hotelName  = string.Empty;
    private string _hotelAddress  = string.Empty;
    private readonly AvaloniaList<Administrator> _hotelAdministrator;

    [Key]
    public int HotelId
    {
        get => _hotelId;
        set => this.RaiseAndSetIfChanged(ref _hotelId, value);
    }

    public string HotelName
    {
        get => _hotelName;
        set => this.RaiseAndSetIfChanged(ref _hotelName, value);
    }

    public string HotelAddress
    {
        get => _hotelAddress;
        set => this.RaiseAndSetIfChanged(ref _hotelAddress, value);
    }

    public AvaloniaList<Administrator> Administrator
    {
        get => _hotelAdministrator;
        init => this.RaiseAndSetIfChanged(ref _hotelAdministrator, value);
    }

    public override Hotel Clone()
    {
        return new Hotel
        {
            HotelId = HotelId,
            HotelName = HotelName,
            HotelAddress = HotelAddress
        };
    }
}