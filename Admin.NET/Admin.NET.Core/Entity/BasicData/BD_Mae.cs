using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMae
{
    public string Id { get; set; } = null!;

    public string? ResNo { get; set; }

    public string? GroupNo { get; set; }

    public string? Type { get; set; }

    public int? PowderType { get; set; }

    public int? Copper { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? DeptId { get; set; }

    public int? IsAvailable { get; set; }

    public DateTime? TakeEffectTime { get; set; }

    public DateTime? InvalidTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
