using System;
using System.ComponentModel.DataAnnotations;

namespace Bkng.Models;

public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    public decimal PaymentTotal { get; set; }
    public DateTimeOffset PaymentDate { get; set; } = DateTimeOffset.Now;
    public PaymentMethod? PaymentMethod { get; set; }
    public Room? PaymentRoom { get; set; }
}