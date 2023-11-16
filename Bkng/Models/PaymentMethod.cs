using System.ComponentModel.DataAnnotations;
using ReactiveUI;

namespace Bkng.Models;

public class PaymentMethod: ModelBase
{
    private int _paymentMethodId;
    private string _paymentMethodValue  = string.Empty;

    [Key]
    public int PaymentMethodId
    {
        get => _paymentMethodId;
        set => this.RaiseAndSetIfChanged(ref _paymentMethodId, value);
    }

    public string PaymentMethodValue
    {
        get => _paymentMethodValue;
        set => this.RaiseAndSetIfChanged(ref _paymentMethodValue, value);
    }

    public override PaymentMethod Clone()
    {
        return new PaymentMethod()
        {
            PaymentMethodId = PaymentMethodId,
            PaymentMethodValue = PaymentMethodValue
        };
    }
}