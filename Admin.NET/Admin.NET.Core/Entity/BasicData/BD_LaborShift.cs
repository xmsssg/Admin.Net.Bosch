using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BLaborShift
{
    public string Id { get; set; } = null!;

    public string SpanId { get; set; } = null!;

    public string ShiftId { get; set; } = null!;

    public int? Qty { get; set; }

    public int? Priority { get; set; }

    public string? OrgId { get; set; }

    public string? WorkDay { get; set; }
}
