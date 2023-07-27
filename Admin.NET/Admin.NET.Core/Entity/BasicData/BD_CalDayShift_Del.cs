using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BD_CalDayShift_Del
{
    public string CalDetailId { get; set; } = null!;

    public string ShiftId { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? OrgId { get; set; }
}
