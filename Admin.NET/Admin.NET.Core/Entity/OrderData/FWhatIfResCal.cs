using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfResCal
{
    public string WhatIfResCalId { get; set; } = null!;

    public string? WhatIfPlanId { get; set; }

    public string ResId { get; set; } = null!;

    public string? WhatIfCalId { get; set; }

    public string? CalId { get; set; }

    public int? Priority { get; set; }

    public string? OrgId { get; set; }
}
