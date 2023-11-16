using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class RoomView : ReactiveUserControl<RoomViewModel>
{
    public RoomView()
    {
        InitializeComponent();
        DataContext = new RoomViewModel();
    }
}