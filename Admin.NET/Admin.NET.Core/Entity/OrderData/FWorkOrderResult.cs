using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderResult
{
    public string WorkOrderId { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public bool? IsConfirmed { get; set; }

    public decimal? Delay { get; set; }

    public decimal? LeadTime { get; set; }

    public decimal? ProductionSpan { get; set; }

    public DateTime? ReleaseDate { get; set; }
}
