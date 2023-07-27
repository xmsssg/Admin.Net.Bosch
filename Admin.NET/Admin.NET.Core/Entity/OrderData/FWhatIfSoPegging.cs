using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfSoPegging
{
    public string Guid { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string? ErppegId { get; set; }

    public string? QmspegId { get; set; }

    public string? ErpsolineId { get; set; }

    public string? QmssolineId { get; set; }

    public int? ProcessLeadTime { get; set; }

    public decimal? DefaultMbdecision { get; set; }

    public string? OrgId { get; set; }
}
