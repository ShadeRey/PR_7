using System;
using System.ComponentModel.DataAnnotations;
using ReactiveUI;

namespace Bkng.Models;

public class Guest: ModelBase
{
    private int _guestId;
    private string _guestFirstName  = string.Empty;
    private string _guestLastName  = string.Empty;
    private string _guestPhone  = string.Empty;

    [Key]
    public int GuestId
    {
        get => _guestId;
        set => this.RaiseAndSetIfChanged(ref _guestId, value);
    }

    public string GuestFirstName
    {
        get => _guestFirstName;
        set => this.RaiseAndSetIfChanged(ref _guestFirstName, value);
    }

    public string GuestLastName
    {
        get => _guestLastName;
        set => this.RaiseAndSetIfChanged(ref _guestLastName, value);
    }

    public string GuestPhone
    {
        get => _guestPhone;
        set => this.RaiseAndSetIfChanged(ref _guestPhone, value);
    }

    public override Guest Clone()
    {
        return new Guest
        {
            GuestId = GuestId,
            GuestFirstName = GuestFirstName,
            GuestLastName = GuestLastName,
            GuestPhone = GuestPhone
        };
    }
}