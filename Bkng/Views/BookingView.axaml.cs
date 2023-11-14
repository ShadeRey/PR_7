using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class BookingView : ReactiveUserControl<BookingViewModel>
{
    public BookingView()
    {
        InitializeComponent();
        DataContext = new BookingViewModel();
    }
}