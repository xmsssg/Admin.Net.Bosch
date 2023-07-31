using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpSecondRe
{
    public string WoopSecondResId { get; set; } = null!;

    public string? WoopId { get; set; }

    public string? SecondResId { get; set; }

    public decimal? Setuptime { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ProcessTime { get; set; }

    public decimal? Priority { get; set; }

    public int? Enabled { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public int? PlanQty { get; set; }

    public string? OrgId { get; set; }
}
