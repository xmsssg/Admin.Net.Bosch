using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoLineForPlan
{
    public string Guid { get; set; } = null!;

    public string SolineId { get; set; } = null!;

    public string? SolineNo { get; set; }

    public string? SolineStatus { get; set; }

    public string? SolinePartNo { get; set; }

    public string? SolinePartDesc { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? SodueDate { get; set; }

    public string? Soid { get; set; }

    public string? Sono { get; set; }

    public string? SoheaderType { get; set; }

    public string? Sostatus { get; set; }

    public string? OrgId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? Priority { get; set; }

    public string? IntegUserId { get; set; }

    public DateTime? IntegTime { get; set; }

    public decimal? Delay { get; set; }

    public string? PlannerCode { get; set; }

    public string? Mfggroup { get; set; }

    public decimal? DemQty { get; set; }

    public DateTime? MrpshipDate { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public DateTime? NovestimatedShipDate { get; set; }

    public DateTime? Est { get; set; }

    public bool? IsForecast { get; set; }

    public string? SolineState { get; set; }

    public int? IsSplited { get; set; }
}
