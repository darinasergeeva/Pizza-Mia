using System;
using System.Collections.Generic;

namespace Pizza_Mia.Models;

public partial class Delivery
{
    public int Id { get; set; }

    public int? IdSupplier { get; set; }

    public int? IdIngredient { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public virtual Ingredient? Ingredient { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
