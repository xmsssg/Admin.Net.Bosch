using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMaterial
{
    public string Id { get; set; } = null!;

    public string? ItemNo { get; set; }

    public int? Batch { get; set; }

    public int? Powder { get; set; }

    public string? Describe { get; set; }

    public string? Group { get; set; }

    public string? EthnicGroup { get; set; }

    public string? Category { get; set; }

    public decimal? Scrap { get; set; }

    public decimal? KanBan { get; set; }

    public int? IsBurr { get; set; }

    public int? IsProcess { get; set; }

    public string? PlanProcess { get; set; }

    public string? DispatchProcess { get; set; }
}
