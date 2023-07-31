using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BShiftTime
{
    public string TimeId { get; set; } = null!;

    public string ShiftId { get; set; } = null!;

    public string? BeginTime { get; set; }

    public string? EndTime { get; set; }

    public string? Remark { get; set; }

    public string? OrgId { get; set; }
}
