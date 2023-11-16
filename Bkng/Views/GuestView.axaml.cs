using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class GuestView : ReactiveUserControl<GuestViewModel>
{
    public GuestView()
    {
        InitializeComponent();
        DataContext = new GuestViewModel();
    }
}