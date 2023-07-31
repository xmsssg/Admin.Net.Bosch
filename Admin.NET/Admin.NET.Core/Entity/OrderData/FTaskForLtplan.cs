using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FTaskForLtplan
{
    public string TaskId { get; set; } = null!;

    public string ScheduleId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? WorkOrderId { get; set; }

    public string? PartId { get; set; }

    public string? Wobomid { get; set; }

    public string? ResId { get; set; }

    public string? LaborId { get; set; }

    public string Opno { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public int? IsFrozen { get; set; }

    public decimal? FrozenQty { get; set; }

    public string? ShopNo { get; set; }

    public decimal? DemandQty { get; set; }

    public string? WoopId { get; set; }

    public string? SecondResId { get; set; }

    public bool? IsLocked { get; set; }
}
