using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class HotelView : ReactiveUserControl<HotelViewModel>
{
    public HotelView()
    {
        InitializeComponent();
        DataContext = new HotelViewModel();
    }
}