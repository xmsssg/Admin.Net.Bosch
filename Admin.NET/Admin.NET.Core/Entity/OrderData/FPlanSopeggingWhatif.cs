using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FPlanSopeggingWhatif
{
    public string PlanSopeggingId { get; set; } = null!;

    public string? PegId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? Delay { get; set; }

    public decimal? SolineLife { get; set; }

    public string? PlanId { get; set; }

    public string? OrgId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? NeedBuyDate { get; set; }

    public int? SupType { get; set; }

    public bool? IsCriticalPath { get; set; }
}
