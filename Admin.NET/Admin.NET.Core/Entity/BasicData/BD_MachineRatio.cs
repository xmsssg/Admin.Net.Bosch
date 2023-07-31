using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMachineRatio
{
    public string Id { get; set; } = null!;

    public string? PartId { get; set; }

    public decimal? ProcessTime { get; set; }

    public int? MachineType { get; set; }
}
