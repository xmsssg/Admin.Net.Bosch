using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfSoPeggingAdd
{
    public string QmspegId { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string? QmsrootPegId { get; set; }

    public string? QmsprePegId { get; set; }

    public int? Qmspeglevel { get; set; }

    public string? SortOrder { get; set; }

    public string? OutPutLevel { get; set; }

    public int? DemQty { get; set; }

    public string? QmssolineId { get; set; }

    public string? QmssolineNo { get; set; }

    public string? PegLinePartId { get; set; }

    public string? PegLinePartNo { get; set; }

    public string? PegLinePartDesc { get; set; }

    public int? SupType { get; set; }

    public int? ProcessLeadTime { get; set; }

    public decimal? DefaultMbdecision { get; set; }

    public string? OrgId { get; set; }

    public string? DispositionIdForPlo { get; set; }

    public string? PolineId { get; set; }

    public string? SupOrderNo { get; set; }

    public DateTime? SupPopromiseDate { get; set; }
}
