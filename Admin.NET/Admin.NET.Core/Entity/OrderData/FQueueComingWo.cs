using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FQueueComingWo
{
    public string Id { get; set; } = null!;

    public string WorkOrderId { get; set; } = null!;

    public decimal? Priority { get; set; }

    public string? OrgId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WorkOrderDesc { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public int? DemandQty { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? EarliestStartTime { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? Delay { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public int? IsReserved { get; set; }

    public int? Type { get; set; }

    public string? CurrentOrgId { get; set; }

    public string? CurrentDepId { get; set; }

    public string? CurrentDepNo { get; set; }

    public string? CurrentDepName { get; set; }

    public string? CurrentResId { get; set; }

    public string? CurrentResNo { get; set; }

    public string? CurrentResName { get; set; }

    public string? CurrentOpNo { get; set; }

    public string? NextOrgId { get; set; }

    public string? NextDepId { get; set; }

    public string? NextDepNo { get; set; }

    public string? NextDepName { get; set; }

    public string? NextResId { get; set; }

    public string? NextResNo { get; set; }

    public string? NextResName { get; set; }

    public string? NextOpNo { get; set; }

    public string? CurrentLastOpNo { get; set; }

    public string? CurrentOpName { get; set; }

    public string? NextLastOpNo { get; set; }
}
