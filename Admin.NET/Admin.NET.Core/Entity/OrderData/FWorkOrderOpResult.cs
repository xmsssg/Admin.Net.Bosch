using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpResult
{
    public string WoopId { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? TotalWorkingTime { get; set; }
}
