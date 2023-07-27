using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMoudleDist
{
    public string Id { get; set; } = null!;

    public string? PartId { get; set; }

    public string? MoudleId { get; set; }

    public DateTime? TakeEffectTime { get; set; }

    public DateTime? InvalidTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
