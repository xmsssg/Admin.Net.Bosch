using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FScheduleWorkOrder
{
    public string ScheduleWoid { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? ScheduleId { get; set; }

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? PartNo { get; set; }

    public decimal? Qty { get; set; }

    public DateTime? EarliestStartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public decimal? Delay { get; set; }

    public decimal? LeadTime { get; set; }

    public decimal? ProductionSpan { get; set; }

    public decimal? JobLife { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public decimal? Priority { get; set; }

    public string? PartName { get; set; }

    public string? ToolingNo { get; set; }

    public string? ResId { get; set; }

    public DateTime? PlanDate { get; set; }
}
