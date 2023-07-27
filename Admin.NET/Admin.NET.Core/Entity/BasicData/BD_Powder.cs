using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BPowder
{
    public string Id { get; set; } = null!;

    public string? PartId { get; set; }

    public string? PowderNo { get; set; }

    public string? ProgramNo { get; set; }

    public DateTime? UpdateTime { get; set; }
}
