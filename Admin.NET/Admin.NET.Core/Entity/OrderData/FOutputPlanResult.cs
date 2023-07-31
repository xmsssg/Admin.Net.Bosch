using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FOutputPlanResult
{
    public string PlanResultId { get; set; } = null!;

    public string Pid { get; set; } = null!;

    public string? PlanId { get; set; }

    public string? OrgId { get; set; }

    public string? OrderNo { get; set; }

    public string? PartNo { get; set; }

    public int? SupType { get; set; }

    public DateTime? NeedByDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public int? BuyOrMake { get; set; }
}
