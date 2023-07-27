using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpStep
{
    public string WoopStepId { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public string? WoopId { get; set; }

    public string? StepId { get; set; }

    public string? StepNo { get; set; }

    public string? StepName { get; set; }

    public string? ResId { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? ProcessTime { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? TotalWorkingTime { get; set; }

    public string? PreStepNo { get; set; }

    public string? NextStepNo { get; set; }

    public string? OriginalOpNo { get; set; }

    public decimal? OriginalResId { get; set; }

    public string? OriginalResNo { get; set; }

    public int? Status { get; set; }

    public DateTime? CompleteTime { get; set; }

    public DateTime? Est { get; set; }

    public decimal? Offset { get; set; }

    public int? Cctype { get; set; }

    public string? OrgId { get; set; }
}
