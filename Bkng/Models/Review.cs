namespace Bkng.Models;

public class Review
{
    public int ReviewId { get; set; }
    public decimal ReviewRating { get; set; }
    public string? ReviewComment { get; set; }
    public int ReviewGuest { get; set; }
    public int ReviewHotel { get; set; }
}