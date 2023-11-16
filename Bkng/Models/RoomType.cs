using System.ComponentModel.DataAnnotations;
using ReactiveUI;

namespace Bkng.Models;

public class RoomType: ModelBase
{
    private int _roomTypeId;
    private string _roomTypeName = string.Empty;
    private string _roomTypeDescription = string.Empty;

    [Key]
    public int RoomTypeId
    {
        get => _roomTypeId;
        set => this.RaiseAndSetIfChanged(ref _roomTypeId, value);
    }

    public string RoomTypeName
    {
        get => _roomTypeName;
        set => this.RaiseAndSetIfChanged(ref _roomTypeName, value);
    }

    public string RoomTypeDescription
    {
        get => _roomTypeDescription;
        set => this.RaiseAndSetIfChanged(ref _roomTypeDescription, value);
    }

    public override RoomType Clone()
    {
        return new RoomType()
        {
            RoomTypeId = RoomTypeId,
            RoomTypeName = RoomTypeName,
            RoomTypeDescription = RoomTypeDescription
        };
    }
}