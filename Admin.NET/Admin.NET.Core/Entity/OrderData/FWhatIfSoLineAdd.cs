using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfSoLineAdd
{
    public string QmssolineId { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string? QmssolineNo { get; set; }

    public string? Qmssono { get; set; }

    public string? SolinePartId { get; set; }

    public string? SolinePartNo { get; set; }

    public string? SolinePartDesc { get; set; }

    public DateTime? SodueDate { get; set; }

    public string? OrgId { get; set; }

    public decimal? Priority { get; set; }

    public DateTime? Est { get; set; }

    public string? CustomerName { get; set; }

    public string? SolineState { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public DateTime? MrpshipDate { get; set; }

    public int? DemQty { get; set; }
}
