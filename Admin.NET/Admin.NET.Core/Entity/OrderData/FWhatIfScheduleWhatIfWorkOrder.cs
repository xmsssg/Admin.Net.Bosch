using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfScheduleWhatIfWorkOrder
{
    public string ScheduleWoid { get; set; } = null!;

    public string? WorkOrderNo { get; set; }

    public string? WhatIfWorkOrderId { get; set; }

    public string? WhatIfScheduleId { get; set; }

    public string? OrgId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }
}
