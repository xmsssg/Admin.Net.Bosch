using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FKanbanList
{
    public string Guid { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? Soid { get; set; }

    public string? Sono { get; set; }

    public string? ResId { get; set; }

    public string? ResDesc { get; set; }

    public string? Fgno { get; set; }

    public string? OrderNumber { get; set; }

    public string? Customer { get; set; }

    public string? Kbquantity { get; set; }

    public string? Unit { get; set; }

    public string? KanbanNo { get; set; }

    public string? Issuser { get; set; }

    public string? DateIfIssue { get; set; }

    public string? FirstBarcode { get; set; }

    public string? OvenProgram { get; set; }

    public string? Gplist { get; set; }

    public string? MachineNo { get; set; }

    public string? LotSize { get; set; }

    public string? Gpnumber { get; set; }

    public string? Gpcount { get; set; }

    public string? Bdno { get; set; }

    public string? Fenliao { get; set; }

    public string? Gpno { get; set; }

    public string? Tooling { get; set; }

    public string? LotCount { get; set; }

    public string? MclineNo { get; set; }

    public string? StartTime { get; set; }

    public string? Bdbarcode { get; set; }

    public string? Gpbarcode { get; set; }

    public string? OrgId { get; set; }

    public int? IsPrinted { get; set; }

    public string? Batch { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? PriorityLine { get; set; }

    public string? AvailableLine { get; set; }

    public string? SerialNo { get; set; }

    public string? RejectedQty { get; set; }

    public string? Kbno { get; set; }

    public string? Kbserial { get; set; }

    public bool? IsMoe { get; set; }

    public int? IsAllowPrint { get; set; }

    public string? Remarks1 { get; set; }

    public string? Remarks2 { get; set; }

    public string? Remarks3 { get; set; }

    public string? DemandQty { get; set; }
}
