using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BLabor
{
    public string LaborId { get; set; } = null!;

    public string? LaborNo { get; set; }

    public string? LaborName { get; set; }

    public int? LaborType { get; set; }

    public int? CapacityType { get; set; }

    public string? LaborGroupId { get; set; }

    public string? OrgId { get; set; }
}
