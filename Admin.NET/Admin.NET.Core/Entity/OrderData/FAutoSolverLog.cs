using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FAutoSolverLog
{
    public string LogId { get; set; } = null!;

    public string? PlanId { get; set; }

    public string? ScheduleId { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UserId { get; set; }

    public string? OrgId { get; set; }

    public string? PreScheduleId { get; set; }

    public decimal? TimeConsumed { get; set; }

    public bool? IsSuccess { get; set; }

    public int? SolverType { get; set; }

    public string? ErrorMsg { get; set; }
}
