using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpResPlan
{
    public string WoopResId { get; set; } = null!;

    public string? WoopId { get; set; }

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

    public bool? NotAllowed { get; set; }

    public decimal? Queuetime { get; set; }

    public decimal? SetupAppliedHours { get; set; }

    public decimal? RunAppliedHours { get; set; }

    public string? ResGroupId { get; set; }

    public int? RequiredLaborQty { get; set; }

    public bool? IsUserDefined { get; set; }

    public decimal? AssignedUnits { get; set; }

    public string? OrgId { get; set; }

    public decimal? Setuptime2 { get; set; }

    public decimal? Setuptime3 { get; set; }

    public string? OpNo { get; set; }

    public string? Resno { get; set; }

    public string? WorkOrderId { get; set; }
}
