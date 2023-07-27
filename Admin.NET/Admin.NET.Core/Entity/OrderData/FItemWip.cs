using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FItemWip
{
    public string WipId { get; set; } = null!;

    public string? PartNo { get; set; }

    public decimal? Wip { get; set; }

    public decimal? Mct { get; set; }

    public decimal? TotalGood { get; set; }

    public decimal? ShippedProduct { get; set; }

    public decimal? ScrapInAssembly { get; set; }

    public decimal? UsedinAssembly { get; set; }

    public decimal? ScrapInInitialPro { get; set; }

    public decimal? TimeWaitingForRes { get; set; }

    public decimal? TimeWaitingForLab { get; set; }

    public decimal? TimeInSetUp { get; set; }

    public decimal? TimeInRun { get; set; }

    public decimal? WaitWip { get; set; }

    public decimal? InProWip { get; set; }

    public string? OrgId { get; set; }
}
