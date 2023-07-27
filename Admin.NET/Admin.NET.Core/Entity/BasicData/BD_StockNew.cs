using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BStockNew
{
    public string Id { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? ItemDesc { get; set; }

    public string? Location { get; set; }

    public string? RinNo { get; set; }

    public string? Batch { get; set; }

    public string? Tono { get; set; }

    public int? Quantity { get; set; }
}
