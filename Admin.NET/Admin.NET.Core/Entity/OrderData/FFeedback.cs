using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FFeedback
{
    public string FeedBackId { get; set; } = null!;

    public string? WorkOrderNo { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public string? ResourceNo { get; set; }

    public string? ResourceName { get; set; }

    public int? QualifiedQty { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? CreatorName { get; set; }

    public string? UpdatorName { get; set; }

    public string? Remark { get; set; }

    public string? OrgId { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? CreatorNo { get; set; }

    public bool? Statistic { get; set; }

    public string Guid { get; set; } = null!;

    public bool? Mesimport { get; set; }

    public DateTime? BeginTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? RepairQty { get; set; }

    public int? WasteQty { get; set; }
}
