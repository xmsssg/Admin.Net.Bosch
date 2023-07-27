using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BStockLocation
{
    public string Guid { get; set; } = null!;

    public string? StockId { get; set; }

    public string? PartNo { get; set; }

    public string? Location { get; set; }

    public string? Batch { get; set; }

    public string? Bin { get; set; }

    public string? Serial { get; set; }

    public decimal? StockQty { get; set; }

    public decimal? AvaliableQoh { get; set; }

    public decimal? Atpqty { get; set; }

    public string? OrgId { get; set; }

    public string? SpecialStock { get; set; }

    public string? StorageType { get; set; }
}
