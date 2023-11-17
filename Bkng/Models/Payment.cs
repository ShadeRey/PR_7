using System;
using System.ComponentModel.DataAnnotations;
using Avalonia.Collections;
using ReactiveUI;

namespace Bkng.Models;

public class Payment: ModelBase
{
    private int _paymentId;
    private decimal _paymentTotal;
    private DateTimeOffset _paymentDate = DateTimeOffset.Now;
    private readonly AvaloniaList<PaymentMethod> _paymentMethod;
    private readonly AvaloniaList<Room> _paymentRoom;

    [Key]
    public int PaymentId
    {
        get => _paymentId;
        set => this.RaiseAndSetIfChanged(ref _paymentId, value);
    }

    public decimal PaymentTotal
    {
        get => _paymentTotal;
        set => this.RaiseAndSetIfChanged(ref _paymentTotal, value);
    }

    public DateTimeOffset PaymentDate
    {
        get => _paymentDate;
        set => this.RaiseAndSetIfChanged(ref _paymentDate, value);
    }

    public AvaloniaList<PaymentMethod> PaymentMethod
    {
        get => _paymentMethod;
        init => this.RaiseAndSetIfChanged(ref _paymentMethod, value);
    }

    public AvaloniaList<Room> PaymentRoom
    {
        get => _paymentRoom;
        init => this.RaiseAndSetIfChanged(ref _paymentRoom, value);
    }

    public override Payment Clone()
    {
        return new Payment
        {
            PaymentId = PaymentId,
            PaymentTotal = PaymentTotal,
            PaymentDate = PaymentDate
        };
    }
}