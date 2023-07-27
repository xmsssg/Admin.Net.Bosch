using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FAreaCapacity
{
    public string CapacityId { get; set; } = null!;

    public decimal? MaximumOutput { get; set; }

    public int? OrderNo { get; set; }

    public string? Area { get; set; }

    public decimal? Stint { get; set; }
}
