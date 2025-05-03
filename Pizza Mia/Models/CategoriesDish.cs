using System;
using System.Collections.Generic;

namespace Pizza_Mia.Models;

public partial class CategoriesDish
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();
}
