using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfPlanSopegging
{
    public string WhatIfPlanSopeggingId { get; set; } = null!;

    public string WhatIfPlanId { get; set; } = null!;

    public string? ErpsolineId { get; set; }

    public string? QmssolineId { get; set; }

    public string? ErppegId { get; set; }

    public string? QmspegId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? Delay { get; set; }

    public decimal? SolineLife { get; set; }

    public string? OrgId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? NeedbyDate { get; set; }

    public int? SupType { get; set; }

    public int? Type { get; set; }

    public bool? IsCriticalPath { get; set; }
}
