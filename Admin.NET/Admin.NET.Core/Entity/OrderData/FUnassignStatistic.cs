using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FUnassignStatistic
{
    public string Guid { get; set; } = null!;

    public string? Workorderno { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public int? UnsignedQty { get; set; }

    public string OrgId { get; set; } = null!;

    public int? TotalQty { get; set; }
}
