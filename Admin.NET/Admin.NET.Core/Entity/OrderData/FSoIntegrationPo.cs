using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoIntegrationPo
{
    public string Id { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? OrganizationId { get; set; }

    public string? Pono { get; set; }

    public string? Class { get; set; }

    public int? Postatus { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? OpNo { get; set; }

    public string? VenderName { get; set; }

    public DateTime? PromiseDate { get; set; }

    public DateTime? NeedbyDate { get; set; }

    public decimal? LineNo { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public int? OrderedQty { get; set; }

    public int? CancelledQty { get; set; }

    public int? ReceivedQty { get; set; }

    public int? RejectedQty { get; set; }

    public int? BilledQty { get; set; }

    public int? AcceptedQty { get; set; }

    public int? ShippedQty { get; set; }

    public string? PoStatus1 { get; set; }

    public DateTime? CreationDate { get; set; }

    public decimal? LeadTime { get; set; }

    public int? InQosp { get; set; }

    public string? PolineId { get; set; }

    public string? PolineShipmentId { get; set; }

    public int? PolineShipmentNo { get; set; }

    public string? BuyerName { get; set; }

    public string? ClosedCode { get; set; }
}
