using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfPlanSoline
{
    public string WhatIfPlanSolineId { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? Duration { get; set; }

    public string? ErpsolineId { get; set; }

    public string? QmssolineId { get; set; }

    public string? OrgId { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? Delay { get; set; }

    public int? Type { get; set; }
}
