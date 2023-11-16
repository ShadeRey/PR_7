using System.ComponentModel.DataAnnotations;

namespace Bkng.Models;

public class Review
{
    [Key]
    public int ReviewId { get; set; }
    public decimal ReviewRating { get; set; }
    public string ReviewComment { get; set; } = string.Empty;
    public Guest? ReviewGuest { get; set; }
    public Hotel? ReviewHotel { get; set; }
}