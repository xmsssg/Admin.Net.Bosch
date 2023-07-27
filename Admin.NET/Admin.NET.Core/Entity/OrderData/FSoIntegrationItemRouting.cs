using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoIntegrationItemRouting
{
    public string Id { get; set; } = null!;

    public string? Guid { get; set; }

    public string? OrgId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? PartVersion { get; set; }

    public string? OrganizationId { get; set; }

    public string? RoutingVersion { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public string? BasisType { get; set; }

    public string? Uom { get; set; }

    public decimal? Queuetime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? ProcessingTime { get; set; }

    public int? RowNum { get; set; }

    public string? PreviousOpNo { get; set; }

    public string? NextOpNo { get; set; }

    public decimal? DefaultMbdecision { get; set; }

    public string? MfgGroup { get; set; }

    public decimal? FullLeadTime { get; set; }

    public string? DepNo { get; set; }

    public string? DrawingNo { get; set; }

    public decimal? AssignedUnits { get; set; }
}
