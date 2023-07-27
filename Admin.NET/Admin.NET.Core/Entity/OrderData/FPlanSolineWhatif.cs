using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FPlanSolineWhatif
{
    public string PlanSolineId { get; set; } = null!;

    public string? SolineId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? Duration { get; set; }

    public string? PlanId { get; set; }

    public string? OrgId { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? Delay { get; set; }
}
