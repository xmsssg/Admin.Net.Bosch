using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FPmcfeedback
{
    public string? JobNo { get; set; }

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

    public DateTime? BeginTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? RepairQty { get; set; }

    public int? WasteQty { get; set; }

    public int Type { get; set; }

    public string? SuspendReason { get; set; }

    public string? Supplement { get; set; }

    public string? SuspendReasonId { get; set; }

    public string? WoopId { get; set; }

    public string? UnusualNo { get; set; }

    public string? SalesOrderNo { get; set; }

    public string? WorkOrderId { get; set; }

    public string? AssignDepId { get; set; }

    public string? AssignDepNo { get; set; }

    public string? AssignedDeptName { get; set; }

    public DateTime? PromiseDate { get; set; }

    public decimal? Priority { get; set; }
}
