using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BStockTempForMrp
{
    public string StockId { get; set; } = null!;

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? OrgId { get; set; }

    public string? Batch { get; set; }

    public int? MaxStock { get; set; }

    public int? MinStock { get; set; }

    public string? ProdMode { get; set; }

    public int? AvailableStock { get; set; }

    public int? CurrentStock { get; set; }

    public decimal? ErrorRate { get; set; }

    public int? SourceType { get; set; }

    public DateTime? PromiseDate { get; set; }

    public string? SubInventoryCode { get; set; }

    public string? Locator { get; set; }

    public string? Location { get; set; }

    public string? SubLocation { get; set; }

    public string? Bin { get; set; }

    public string? Lot { get; set; }

    public string? Serial { get; set; }

    public int? Atpqty { get; set; }

    public int? CommittedQty { get; set; }

    public bool? IsBad { get; set; }

    public int? AllocatedQty { get; set; }

    public int? AvailableQoh { get; set; }

    public int? SafetyStock { get; set; }

    public int? LeadTime { get; set; }

    public int? ShortageQty { get; set; }

    public int? InventoryCalculation { get; set; }
}
