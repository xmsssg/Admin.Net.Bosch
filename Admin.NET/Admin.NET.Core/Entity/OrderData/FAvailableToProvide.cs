using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FAvailableToProvide
{
    public string Atpid { get; set; } = null!;

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? OrgId { get; set; }

    public int? CurrentAvailableQty { get; set; }

    public int? Atpqty { get; set; }

    public int? SupType { get; set; }

    public int? CommittedQty { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public DateTime? NeedbyDate { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? OrderNo { get; set; }

    public string? PartDesc { get; set; }

    public int? OracleJobStatus { get; set; }

    public string? PolineId { get; set; }

    public string? Poid { get; set; }

    public int? WhatIfAllocatedQty { get; set; }

    public string? PolineShipmentId { get; set; }

    public DateTime? PromiseDate { get; set; }
}
