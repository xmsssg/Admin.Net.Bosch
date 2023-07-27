using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpResResult
{
    public string WoopResId { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string? WoopId { get; set; }

    public string? ResId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public int? PlanQty { get; set; }
}
