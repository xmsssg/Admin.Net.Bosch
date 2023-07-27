using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatifWorkOrderTempForMrp
{
    public string WorkOrderId { get; set; } = null!;

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

    public decimal? Delay { get; set; }

    public decimal? LeadTime { get; set; }

    public decimal? ProductionSpan { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? OracleJobStatus { get; set; }

    public DateTime? OracleLastUpdateTime { get; set; }

    public string? CurrentOpNo { get; set; }

    public string? CurrentResId { get; set; }

    public string? NextOpNo { get; set; }

    public string? NextResId { get; set; }

    public string? CurrentOrgId { get; set; }

    public string? NextOrgId { get; set; }

    public string? CurrentDepId { get; set; }

    public string? NextDepId { get; set; }

    public bool? EditLock { get; set; }

    public DateTime? OracleCompletionDate { get; set; }

    public string? ReleasedOrgId { get; set; }

    public string? ReleasedUserId { get; set; }

    public string? Wolevel { get; set; }

    public string? Remarks { get; set; }

    public string? PartRevision { get; set; }

    public string? CurrentLastOpNo { get; set; }

    public int? ShortageStatus { get; set; }

    public string? PlannerCode { get; set; }

    public decimal? AllStandardHours { get; set; }

    public decimal? AllAppliedHours { get; set; }

    public decimal? AllTotalWorkingTime { get; set; }

    public decimal? AllVariance { get; set; }

    public decimal? AllIncompleteStandardHours { get; set; }

    public int? Firm { get; set; }

    public int? HasRework { get; set; }

    public string? ReworkContent { get; set; }

    public string? Pocontent { get; set; }

    public string? AllWorkOrderNo { get; set; }

    public int? RejectedQty { get; set; }

    public decimal? ScheduledHours { get; set; }

    public string? Sodetail { get; set; }

    public string? Mfggroup { get; set; }

    public decimal? NetQuantity { get; set; }

    public bool? IsRoutingCustom { get; set; }

    public int? Atpqty { get; set; }

    public int? Wotype { get; set; }
}
