using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BProgramLine
{
    public string Id { get; set; } = null!;

    public string? ProgramNo { get; set; }

    public int? Type { get; set; }

    public string? DeptId { get; set; }

    public string? DeptNo { get; set; }

    public int? IsAvailable { get; set; }

    public DateTime? TakeEffectTime { get; set; }

    public DateTime? InvalidTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Priority { get; set; }

    public string? AvailableLine { get; set; }
}
