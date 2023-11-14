using System;

namespace Bkng.Models;

public class Payment
{
    public int PaymentId { get; set; }
    public decimal PaymentTotal { get; set; }
    public DateTimeOffset? PaymentDate { get; set; }
    public int PaymentMethod { get; set; }
    public int PaymentRoom { get; set; }
}