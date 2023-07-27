using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FItemTotalUtil
{
    public string TotalUtilId { get; set; } = null!;

    public string? ItemNo { get; set; }

    public decimal? TotalUtil { get; set; }

    public decimal? RunUtil { get; set; }

    public decimal? SetUpUtil { get; set; }

    public decimal? WaitUtil { get; set; }

    public decimal? Idle { get; set; }

    public decimal? TotalWip { get; set; }

    public string? OrgId { get; set; }
}
