using System.ComponentModel.DataAnnotations;
using Avalonia.Collections;
using ReactiveUI;

namespace Bkng.Models;

public class Review: ModelBase
{
    private int _reviewId;
    private decimal _reviewRating;
    private string _reviewComment = string.Empty;
    private AvaloniaList<Guest> _reviewGuest;
    private AvaloniaList<Hotel> _reviewHotel;

    [Key]
    public int ReviewId
    {
        get => _reviewId;
        set => this.RaiseAndSetIfChanged(ref _reviewId, value);
    }

    public decimal ReviewRating
    {
        get => _reviewRating;
        set => this.RaiseAndSetIfChanged(ref _reviewRating, value);
    }

    public string ReviewComment
    {
        get => _reviewComment;
        set => this.RaiseAndSetIfChanged(ref _reviewComment, value);
    }

    public AvaloniaList<Guest> Guest
    {
        get => _reviewGuest;
        init => this.RaiseAndSetIfChanged(ref _reviewGuest, value);
    }

    public AvaloniaList<Hotel> Hotel
    {
        get => _reviewHotel;
        init => this.RaiseAndSetIfChanged(ref _reviewHotel, value);
    }

    public override Review Clone()
    {
        return new Review
        {
            ReviewId = ReviewId,
            ReviewRating = ReviewRating,
            ReviewComment = ReviewComment
        };
    }
}