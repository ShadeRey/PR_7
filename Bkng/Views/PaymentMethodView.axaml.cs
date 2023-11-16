using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Bkng.ViewModels;

namespace Bkng.Views;

public partial class PaymentMethodView : ReactiveUserControl<PaymentMethodViewModel>
{
    public PaymentMethodView()
    {
        InitializeComponent();
        DataContext = new PaymentMethodViewModel();
    }
}