using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FProgram
{
    public string ProgramId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? ProgramNo { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? PartRevision { get; set; }

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WorkOrderDesc { get; set; }

    public string? OpNo { get; set; }

    public string? OpDesc { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? ResId { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedUserNo { get; set; }

    public string? CreatedUserId { get; set; }

    public string? DrawingNo { get; set; }

    public bool Flag { get; set; }
}
