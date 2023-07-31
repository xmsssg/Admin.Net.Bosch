using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FOutputTaskStatistic
{
    public string TaskId { get; set; } = null!;

    public string Sid { get; set; } = null!;

    public string? ScheduleId { get; set; }

    public string? OrgId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? PartNo { get; set; }

    public string? Wobomno { get; set; }

    public string? ResNo { get; set; }

    public string? LaborNo { get; set; }

    public string? Opno { get; set; }

    public string? Opnos { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public int? IsFrozen { get; set; }

    public decimal? FrozenQty { get; set; }

    public string? ShopNo { get; set; }

    public decimal? DemandQty { get; set; }

    public decimal? ProcessTime { get; set; }
}
