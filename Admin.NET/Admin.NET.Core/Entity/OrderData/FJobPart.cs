using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FJobPart
{
    public string Id { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? JobId { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? PartLevel { get; set; }

    public string? MakeorBuy { get; set; }

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? Poid { get; set; }

    public string? Pono { get; set; }

    public int? ShortageStatus { get; set; }

    public string? Remarks { get; set; }

    public string? PartName { get; set; }
}
