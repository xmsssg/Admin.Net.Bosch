using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BLaintegrationHistoryJobRouting
{
    public string? Guid { get; set; }

    public string? OrgId { get; set; }

    public string? JobNo { get; set; }

    public string? JobName { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public int? DemandQty { get; set; }

    public int? CompletedQty { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? OracleCompletionDate { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public int? OpDemandQty { get; set; }

    public int? OpCompletedQty { get; set; }

    public int? OpScrapedQty { get; set; }

    public int? OpAccumulateScrapedQty { get; set; }

    public int? OpRejectedQty { get; set; }

    public DateTime? OsppromiseDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? WorkCenterNo { get; set; }

    public int? Units { get; set; }

    public string? DepId { get; set; }

    public string? DepNo { get; set; }

    public string? DepName { get; set; }

    public string? ResId { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public bool? CurrentlyAssigned { get; set; }

    public string? Uom { get; set; }

    public int? BasisType { get; set; }

    public decimal? Queuetime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? ProcessingTime { get; set; }

    public decimal? SetUpAppliedHours { get; set; }

    public decimal? RunAppliedHours { get; set; }

    public DateTime? NovAddedTime { get; set; }

    public decimal? InQueue { get; set; }

    public string? Attribute1 { get; set; }

    public int? JobStatus { get; set; }

    public DateTime? OracleLastUpdateTime { get; set; }

    public string? BelongOrgId { get; set; }

    public string? NextOpNo { get; set; }

    public string? PreviousOpNo { get; set; }

    public DateTime? OpLastMovedDate { get; set; }

    public int? RowNum { get; set; }

    public string? PartRevision { get; set; }

    public string? PlannerCode { get; set; }

    public int? MoveToQty { get; set; }

    public string? Mfggroup { get; set; }

    public DateTime? OracleCompleteDate { get; set; }
}
