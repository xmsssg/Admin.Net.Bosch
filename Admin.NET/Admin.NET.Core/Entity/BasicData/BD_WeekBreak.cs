using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWeekBreak
{
    public string Id { get; set; } = null!;

    public int? ThisWeek { get; set; }

    public string? BreakDesc { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? Type { get; set; }

    public string? OrgId { get; set; }

    public int? OrderBy { get; set; }
}
