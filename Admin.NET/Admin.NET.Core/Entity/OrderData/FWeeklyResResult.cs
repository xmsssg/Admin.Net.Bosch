using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWeeklyResResult
{
    public string WeeklyResResultId { get; set; } = null!;

    public string? ResId { get; set; }

    public int? Sort { get; set; }

    public string? Time { get; set; }

    public string? OrgId { get; set; }
}
