using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BVarianceStatistic
{
    public string Id { get; set; } = null!;

    public string DepId { get; set; } = null!;

    public decimal? PositiveVarianceForInP { get; set; }

    public decimal? PositiveVarianceForCom { get; set; }

    public decimal? NegativeVariance { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? OrgId { get; set; }
}
