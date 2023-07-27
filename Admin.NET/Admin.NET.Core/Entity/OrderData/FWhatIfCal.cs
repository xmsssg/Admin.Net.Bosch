using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfCal
{
    public string WhatIfCalId { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string? CalId { get; set; }

    public string? OrgId { get; set; }

    public string? CalNo { get; set; }

    public string? CalName { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Remark { get; set; }

    public int? Type { get; set; }

    public decimal? Priority { get; set; }

    public decimal? ResId { get; set; }

    public int? IsDefault { get; set; }
}
