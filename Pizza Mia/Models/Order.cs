using System;
using System.Collections.Generic;

namespace Pizza_Mia.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public int IdCustomer { get; set; }

    public decimal TotalAmount { get; set; }

    public string? Status { get; set; }

    public virtual Customer? Customer { get; set; }
}
