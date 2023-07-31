using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BPartRoutingPlan
{
    public string PartRoutingId { get; set; } = null!;

    public string? PartRoutingNo { get; set; }

    public string? PartRoutingName { get; set; }

    public string? OrgId { get; set; }

    public string? PartId { get; set; }

    public int? IsStandard { get; set; }
}
