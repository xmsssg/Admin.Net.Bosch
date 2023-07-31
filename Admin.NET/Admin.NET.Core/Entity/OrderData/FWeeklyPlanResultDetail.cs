using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWeeklyPlanResultDetail
{
    public string Guid { get; set; } = null!;

    public string? WeeklyPlanResultId { get; set; }

    public DateTime? Sort { get; set; }

    public decimal? Qty { get; set; }

    public string? Type { get; set; }

    public string? Gpid { get; set; }

    public string? Fgid { get; set; }

    public string? OrgId { get; set; }

    public string? Region { get; set; }
}
