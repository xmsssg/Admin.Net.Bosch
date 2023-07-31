using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkingSpan
{
    public string SpanId { get; set; } = null!;

    public string LaborGroupId { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public int? LaborQty { get; set; }

    public string? OrgId { get; set; }

    public string? WorkSpanNo { get; set; }

    public string? WorkDay { get; set; }
}
