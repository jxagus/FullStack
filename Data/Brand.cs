using System;
using System.Collections.Generic;

namespace Data;

public partial class Brand
{
    private int? id;

    public Brand(int? id, string name)
    {
        this.id = id;
        Name = name;
    }

    public int Id { get; set; }

    public string? Name { get; set; }
}
