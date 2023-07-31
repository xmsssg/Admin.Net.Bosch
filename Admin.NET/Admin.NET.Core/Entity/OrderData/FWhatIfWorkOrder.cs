using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfWorkOrder
{
    public string WhatIfWorkOrderId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WorkOrderDesc { get; set; }

    public int? DemandQty { get; set; }

    public DateTime? EarliestStartTime { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? Priority { get; set; }

    public bool? IsActive { get; set; }

    public string? JobId { get; set; }

    public int? Status { get; set; }

    public DateTime? AddedTime { get; set; }

    public int? SubProductType { get; set; }

    public int? Incomplete { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public bool? IsConfirmed { get; set; }

    public string? WhatIfScheduleId { get; set; }

    public string? WorkOrderId { get; set; }

    public decimal? Delay { get; set; }

    public decimal? LeadTime { get; set; }

    public decimal? ProductionSpan { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? OracleJobStatus { get; set; }

    public string? CurrentOpNo { get; set; }

    public string? CurrentResId { get; set; }

    public string? NextOpNo { get; set; }

    public string? NextResId { get; set; }

    public string? CurrentOrgId { get; set; }

    public string? CurrentDepId { get; set; }

    public string? NextOrgId { get; set; }

    public string? NextDepId { get; set; }
}
