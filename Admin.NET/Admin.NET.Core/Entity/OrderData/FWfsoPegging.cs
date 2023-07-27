using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWfsoPegging
{
    public string Guid { get; set; } = null!;

    public string? PegId { get; set; }

    public string? PrePegId { get; set; }

    public string? RootPegId { get; set; }

    public int? PegLevel { get; set; }

    public string? SortOrder { get; set; }

    public string? OutputLevel { get; set; }

    public int? DemQty { get; set; }

    public int? SupQty { get; set; }

    public int? AllocatedQty { get; set; }

    public string? PartId { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? SodueDate { get; set; }

    public string? Soid { get; set; }

    public string? Sono { get; set; }

    public string? SoheaderType { get; set; }

    public string? Sostatus { get; set; }

    public string? SolineId { get; set; }

    public string? SolineNo { get; set; }

    public string? SolineStatus { get; set; }

    public string? SolinePartNo { get; set; }

    public string? SolinePartDesc { get; set; }

    public string? PegLinePartNo { get; set; }

    public string? PegLinePartDesc { get; set; }

    public string? PeggingLinePartStatus { get; set; }

    public string? DemId { get; set; }

    public string? DemSourceWithDemType { get; set; }

    public string? DemSource { get; set; }

    public int? SupType { get; set; }

    public string? SupOrderNo { get; set; }

    public string? SupOrderId { get; set; }

    public int? ProcessLeadTime { get; set; }

    public DateTime? SupPopromiseDate { get; set; }

    public int? Location { get; set; }

    public decimal? DefaultMbdecision { get; set; }

    public int? DispositionIdForPlo { get; set; }

    public int? PolineId { get; set; }

    public int? PolineShipmentId { get; set; }

    public string? OrgId { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public string? IntegUserId { get; set; }

    public DateTime? IntegTime { get; set; }

    public string? SupOrderDesc { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? NeedByDate { get; set; }

    public string? PlannerCode { get; set; }

    public string? Mfggroup { get; set; }

    public DateTime? MrpshipDate { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public DateTime? NovestimatedShipDate { get; set; }

    public int? QtyOnHand { get; set; }

    public int? Atpqty { get; set; }

    public bool? IsForcast { get; set; }

    public string? Subinventorylocation { get; set; }

    public int? IsUsed { get; set; }
}
