using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FHistoryWorkOrder
{
    public string HWorkOrderId { get; set; } = null!;

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

    public bool? EditLock { get; set; }

    public string? PlannerCode { get; set; }

    public string? PartRevision { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? OracleJobStatus { get; set; }

    public DateTime? OracleCompletionDate { get; set; }

    public DateTime? OracleLastUpdateTime { get; set; }

    public decimal? AllStandardHours { get; set; }

    public decimal? AllAppliedHours { get; set; }

    public decimal? AllVariance { get; set; }

    public decimal? AllIncompleteStandardHours { get; set; }

    public string? Mfggroup { get; set; }

    public decimal? AllAbsVar { get; set; }

    public decimal? AllFavorVar { get; set; }

    public decimal? AllUnFavorVar { get; set; }

    public DateTime? CompletionDate { get; set; }

    public decimal? LeadTime { get; set; }

    public decimal? Delay { get; set; }
}
