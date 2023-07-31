using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfSoLine
{
    public string Guid { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string? ErpsolineId { get; set; }

    public string? QmssolineId { get; set; }

    public DateTime? SodueDate { get; set; }

    public string? OrgId { get; set; }

    public decimal? Priority { get; set; }

    public DateTime? Est { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public DateTime? MrpshipDate { get; set; }

    public int? DemQty { get; set; }
}
