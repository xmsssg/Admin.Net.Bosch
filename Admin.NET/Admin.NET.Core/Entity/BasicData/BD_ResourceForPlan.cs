using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BResourceForPlan
{
    public string ResId { get; set; } = null!;

    public string? DepId { get; set; }

    public string ResNo { get; set; } = null!;

    public string? ResName { get; set; }

    public string? ResDesc { get; set; }

    public int? Status { get; set; }

    public int? Type { get; set; }

    public int? ResType { get; set; }

    public bool? IsDefault { get; set; }

    public string? WorkCenterNo { get; set; }

    public int Units { get; set; }

    public int? Programmable { get; set; }

    public int? IsSeparable { get; set; }

    public int IsAvailable { get; set; }

    public int? IsHeattreat { get; set; }

    public string? OrgId { get; set; }
}
