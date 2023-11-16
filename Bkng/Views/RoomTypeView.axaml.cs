using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class RoomTypeView : ReactiveUserControl<RoomTypeViewModel>
{
    public RoomTypeView()
    {
        InitializeComponent();
        DataContext = new RoomViewModel();
    }
}