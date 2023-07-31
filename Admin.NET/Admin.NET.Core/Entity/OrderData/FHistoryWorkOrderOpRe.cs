using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FHistoryWorkOrderOpRe
{
    public string HWoopResId { get; set; } = null!;

    public string? HWoopId { get; set; }

    public string? ResId { get; set; }

    public decimal? Setuptime { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ProcessTime { get; set; }

    public decimal? Priority { get; set; }

    public int? Enabled { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public int? PlanQty { get; set; }

    public int? SetupQty { get; set; }

    public bool Assigned { get; set; }

    public decimal AppliedHours { get; set; }

    public decimal? Queuetime { get; set; }

    public decimal? SetupAppliedHours { get; set; }

    public decimal? RunAppliedHours { get; set; }

    public string? ResGroupId { get; set; }

    public int? RequiredLaborQty { get; set; }

    public string? OrgId { get; set; }
}
