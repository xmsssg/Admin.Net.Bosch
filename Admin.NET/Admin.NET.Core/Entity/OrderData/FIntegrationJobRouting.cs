using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FIntegrationJobRouting
{
    public string? Guid { get; set; }

    public string? OrgId { get; set; }

    public string? JobNo { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public int? DemandQty { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public string? OpFunction { get; set; }

    public int? OpDemandQty { get; set; }

    public int? OpCompletedQty { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public string? DepNo { get; set; }

    public string? DepName { get; set; }

    public int? SetupQuantity { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? ProcessingTime { get; set; }

    public decimal? AppliedHours { get; set; }

    public decimal? OpFixLt { get; set; }

    public decimal? Qtime { get; set; }

    public DateTime? RequiredDate { get; set; }
}
