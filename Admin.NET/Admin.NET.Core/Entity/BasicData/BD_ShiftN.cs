using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BShiftN
{
    public string ShiftId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string ShiftNo { get; set; } = null!;

    public string? ShiftName { get; set; }

    public int? Enable { get; set; }

    public string? Remark { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? ResId { get; set; }
}
