using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWeeklyPlanResult
{
    public string WeeklyPlanResultId { get; set; } = null!;

    public int? Sort { get; set; }

    public string? Fg { get; set; }

    public string? Fgid { get; set; }

    public string? Gp { get; set; }

    public string? Gpid { get; set; }

    public decimal? Usage { get; set; }

    public string? Region { get; set; }

    public int? Moq { get; set; }

    public string? Item { get; set; }

    public string? Tooling { get; set; }

    public decimal? ToolingCapacity { get; set; }

    public decimal? ToolingTtl { get; set; }

    public decimal? Stcok { get; set; }

    public decimal? Backlog { get; set; }

    public int? OrderNum { get; set; }

    public string? OrgId { get; set; }

    public DateTime? StartTime { get; set; }

    public int? Units { get; set; }

    public string? PowderCharacteristics { get; set; }

    public decimal? CavitiesNum { get; set; }
}
