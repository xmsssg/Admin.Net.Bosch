using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWhatifOperation
{
    public string OpId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? PartId { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public string? OpDesc { get; set; }

    public int? Status { get; set; }

    public decimal? DefectsRate { get; set; }

    public decimal? LotSize { get; set; }

    public int? BatchMachs { get; set; }

    public decimal? TransferTime { get; set; }

    public string? Ifv { get; set; }

    public string? Offset { get; set; }

    public string? Eoffset { get; set; }

    public string? PartRoutingId { get; set; }

    public string? Function { get; set; }

    public int? Uom { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? NextOpNo { get; set; }

    public string? PreviousOpNo { get; set; }

    public string? OpSortNo { get; set; }

    public decimal? StandardHours { get; set; }
}
