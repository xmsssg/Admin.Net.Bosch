using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWeeklyResResultDetail
{
    public string Guid { get; set; } = null!;

    public string? WeeklyResResultId { get; set; }

    public string? ResId { get; set; }

    public DateTime? Sort { get; set; }

    public decimal? Qty { get; set; }

    public string? Type { get; set; }

    public string? OrgId { get; set; }
}
