using System;
using System.Collections.Generic;

namespace Pizza_Mia.Models;

public partial class DishIgredient
{
    public int IdDish { get; set; }

    public int IdIngredient { get; set; }

    public decimal? Amount { get; set; }

    public virtual Dish IdDishNavigation { get; set; } = null!;

    public virtual Ingredient Ingredient { get; set; } = null!;
}
