using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMoudle
{
    public string Id { get; set; } = null!;

    public string? ResNo { get; set; }

    public string? Type { get; set; }

    public int? LotSize { get; set; }

    public string? DepId { get; set; }

    public int? IsAvailable { get; set; }

    public DateTime? TakeEffectTime { get; set; }

    public DateTime? InvalidTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
