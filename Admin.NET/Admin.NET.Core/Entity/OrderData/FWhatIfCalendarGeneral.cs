using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfCalendarGeneral
{
    public string WhatIfGuid { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string? Guid { get; set; }

    public string? ResId { get; set; }

    public string? ResNo { get; set; }

    public string? OrgId { get; set; }

    public string? CalNo { get; set; }

    public string? CalName { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Remark { get; set; }

    public string? WorkDay { get; set; }

    public string? Shift1 { get; set; }

    public string? Shift2 { get; set; }

    public string? Shift3 { get; set; }

    public int? Type { get; set; }

    public decimal? Priority { get; set; }

    public int? IsDefault { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? CalId { get; set; }

    public string? WhatIfCalId { get; set; }
}
