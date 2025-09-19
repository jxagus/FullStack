using System;
using System.Collections.Generic;

namespace Data;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Cost { get; set; }

    public string Price { get; set; } = null!;

    public int Brandld { get; set; }

    public bool Active { get; set; }

    public DateTime Date { get; set; }
}
