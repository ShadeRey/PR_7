using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class AdministratorView : ReactiveUserControl<AdministratorViewModel>
{
    public AdministratorView()
    {
        InitializeComponent();
        DataContext = new AdministratorViewModel();
    }
}