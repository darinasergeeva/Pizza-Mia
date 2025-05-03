using System;
using System.Collections.Generic;

namespace Pizza_Mia.Models;

public partial class Ingredient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Unit { get; set; }

    public int StockQuantity { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual ICollection<DishIgredient> DishIgredients { get; set; } = new List<DishIgredient>();
}
