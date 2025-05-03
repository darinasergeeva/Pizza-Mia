using System;
using System.Collections.Generic;

namespace Pizza_Mia.Models;

public partial class Dish
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? IdCategory { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int СookingTime { get; set; }

    public string Photo { get; set; } = null!;

    public virtual ICollection<DishIgredient> DishIgredients { get; set; } = new List<DishIgredient>();

    public virtual CategoriesDish? CategoriesDish { get; set; }
}
