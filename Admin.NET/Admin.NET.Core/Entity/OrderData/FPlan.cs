using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FPlan
{
    public string PlanId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string PlanNo { get; set; } = null!;

    public string? PlanName { get; set; }

    public string? PlanDesc { get; set; }

    public int? IsConfirmed { get; set; }

    public int? PlanTarget { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public int? FrozenDays { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public DateTime? CancelConfirmTime { get; set; }

    public string? Parameters { get; set; }

    public int? PlanedJobsCount { get; set; }

    public int? PlanedPartsCount { get; set; }

    public int? LateJobsCount { get; set; }

    public int? OnTimeJobsCount { get; set; }

    public decimal? AverageDelay { get; set; }

    public decimal? AverageLeadtime { get; set; }

    public decimal? MaxDelay { get; set; }

    public decimal? MinDelay { get; set; }

    public decimal? MaxLeadtime { get; set; }

    public decimal? MinLeadtime { get; set; }

    public decimal? ProductionSpan { get; set; }

    public decimal? AverageDailyWip { get; set; }

    public int? ProductedJobsCount { get; set; }

    public decimal? AvgProductionPeriod { get; set; }

    public int? OptimizationObjective1 { get; set; }

    public int? OptimizationObjective2 { get; set; }

    public decimal? MaxJobLife { get; set; }

    public decimal? AvgJobLife { get; set; }

    public string? UserId { get; set; }

    public int? PlanClass { get; set; }

    public int? Type { get; set; }

    public bool? IsAuto { get; set; }

    public string? PreScheduleId { get; set; }

    public string? SchedulerOrgId { get; set; }
}
