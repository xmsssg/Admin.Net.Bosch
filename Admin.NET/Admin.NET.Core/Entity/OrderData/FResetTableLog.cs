using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FResetTableLog
{
    public string Id { get; set; } = null!;

    public string? PlanId { get; set; }

    public string? ScheduleId { get; set; }

    public string? WorkOrderId { get; set; }

    public decimal? BeforeValue { get; set; }

    public decimal? AfterValue { get; set; }

    public DateTime? PlanTime { get; set; }

    public DateTime? CreateTime { get; set; }
}
