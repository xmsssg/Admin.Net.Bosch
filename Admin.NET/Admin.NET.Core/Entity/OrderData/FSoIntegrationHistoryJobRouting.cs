using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoIntegrationHistoryJobRouting
{
    public string Id { get; set; } = null!;

    public string? Guid { get; set; }

    public string? OrgId { get; set; }

    public string? JobNo { get; set; }

    public string? JobName { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public decimal? DemandQty { get; set; }

    public decimal? CompletedQty { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public decimal? OpDemandQty { get; set; }

    public decimal? OpCompletedQty { get; set; }

    public decimal? OpScrapedQty { get; set; }

    public decimal? OpRejectedQty { get; set; }

    public DateTime? OsppromiseDate { get; set; }

    public string? WorkCenterNo { get; set; }

    public decimal? Units { get; set; }

    public string? DepNo { get; set; }

    public string? DepName { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public bool? CurrentlyAssigned { get; set; }

    public string? Uom { get; set; }

    public decimal? BasisType { get; set; }

    public decimal? Queuetime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? ProcessingTime { get; set; }

    public decimal? SetupAppliedHours { get; set; }

    public decimal? RunAppliedHours { get; set; }

    public DateTime? NovAddedTime { get; set; }

    public decimal? InQueue { get; set; }

    public string? Attribute1 { get; set; }

    public int? JobStatus { get; set; }

    public string? OrganizationId { get; set; }

    public DateTime? JobCloseDate { get; set; }

    public DateTime? OracleLastUpdateTime { get; set; }

    public decimal? JobPriority { get; set; }

    public DateTime? DueDate1 { get; set; }

    public string? Bomid { get; set; }

    public string? RoutingId { get; set; }

    public string? Bomrevision { get; set; }

    public string? RoutingRevision { get; set; }

    public string? AlternateBomDesignator { get; set; }

    public string? AlternateRoutingDesignator { get; set; }

    public DateTime? OpLastMovedDate { get; set; }

    public int RowNum { get; set; }

    public string? PartRevision { get; set; }

    public string? PlannerCode { get; set; }

    public int? MoveToQty { get; set; }

    public string? Mfggroup { get; set; }

    public DateTime? OracleCompleteDate { get; set; }
}
