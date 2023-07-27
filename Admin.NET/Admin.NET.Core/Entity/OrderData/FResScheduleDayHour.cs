using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FResScheduleDayHour
{
    public string Id { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WoopId { get; set; }

    public string? OpNo { get; set; }

    public string? ResId { get; set; }

    public string? ResNo { get; set; }

    public string? WorkCenterNo { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public decimal? Duration { get; set; }

    public string? OrgId { get; set; }

    public decimal? AvailableHours { get; set; }

    public DateTime? CurrentDate { get; set; }
}
