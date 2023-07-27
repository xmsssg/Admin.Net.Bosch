using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BLaborGroup
{
    public string LaborGroupId { get; set; } = null!;

    public string? LaborGroupNo { get; set; }

    public string? LaborGroupName { get; set; }

    public int? LaborQty { get; set; }

    public string? OrgId { get; set; }
}
