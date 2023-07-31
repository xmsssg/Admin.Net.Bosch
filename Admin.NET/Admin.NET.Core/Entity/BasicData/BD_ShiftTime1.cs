using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BShiftTime1
{
    public string ShiftId { get; set; } = null!;

    public string? Remark { get; set; }

    public string? OrgId { get; set; }

    public string ShiftName { get; set; } = null!;

    public string? ShiftTime { get; set; }

    public string? WorkSpanNo { get; set; }

    public string? LaborGroupId { get; set; }
}
