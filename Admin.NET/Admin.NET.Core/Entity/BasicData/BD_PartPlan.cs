using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BPartPlan
{
    public string PartId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? PartDesc { get; set; }

    public int? PartType { get; set; }

    public int? ProductType { get; set; }

    public string? UnitId { get; set; }

    public string? AttachName { get; set; }

    public string? UrlPath { get; set; }

    public byte[]? Attachment { get; set; }

    public decimal? DefaultMbdecision { get; set; }

    public string? MfgGroup { get; set; }

    public decimal? FullLeadTime { get; set; }

    public string? PlannerCode { get; set; }

    public string? DrawingNo { get; set; }

    public decimal? SupplyType { get; set; }

    public int? LotSize { get; set; }

    public decimal? SetupTimeSt { get; set; }

    public int? ResPriority { get; set; }
}
