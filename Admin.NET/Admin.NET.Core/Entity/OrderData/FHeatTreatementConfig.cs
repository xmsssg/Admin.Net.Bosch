using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FHeatTreatementConfig
{
    public string ResId { get; set; } = null!;

    public string? ReaName { get; set; }

    public int? StoveBatchQty { get; set; }

    public string? OrgId { get; set; }
}
