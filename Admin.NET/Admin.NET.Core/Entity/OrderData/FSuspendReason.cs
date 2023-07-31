using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSuspendReason
{
    public string? SuspendReasonNo { get; set; }

    public string? SuspendReasonDesc { get; set; }

    public string? OrgId { get; set; }

    public DateTime? SuspendTime { get; set; }

    public string? WorkOrderId { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string SuspendReasonId { get; set; } = null!;
}
