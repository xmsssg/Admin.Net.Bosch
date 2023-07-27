using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BOpSecondRe
{
    public string OpSecondResId { get; set; } = null!;

    public string? PartId { get; set; }

    public string? Bomid { get; set; }

    public string? OpId { get; set; }

    public string? SecondResId { get; set; }

    public decimal? Setuptime { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ProcessTime { get; set; }

    public decimal? Priority { get; set; }

    public int? Enabled { get; set; }

    public string? OrgId { get; set; }
}
