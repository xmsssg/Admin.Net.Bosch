using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FItemOpDetail
{
    public string DetailId { get; set; } = null!;

    public string? ItemNo { get; set; }

    public string? OpNo { get; set; }

    public decimal? ResSetup { get; set; }

    public decimal? ResRun { get; set; }

    public decimal? WaitforRes { get; set; }

    public decimal? OpMct { get; set; }

    public decimal? OpWip { get; set; }

    public string? OrgId { get; set; }
}
