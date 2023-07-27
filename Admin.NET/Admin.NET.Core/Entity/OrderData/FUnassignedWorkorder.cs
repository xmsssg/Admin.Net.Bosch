using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FUnassignedWorkorder
{
    public string Guid { get; set; } = null!;

    public string? Workorderno { get; set; }

    public string? OpNo { get; set; }

    public int? UnsignedQty { get; set; }

    public string OrgId { get; set; } = null!;

    public string UnassignStatisticGuid { get; set; } = null!;
}
