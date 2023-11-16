using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class PaymentView : ReactiveUserControl<PaymentViewModel>
{
    public PaymentView()
    {
        InitializeComponent();
        DataContext = new PaymentViewModel();
    }
}