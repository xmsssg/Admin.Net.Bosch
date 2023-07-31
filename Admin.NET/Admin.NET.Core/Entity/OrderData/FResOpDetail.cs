using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FResOpDetail
{
    public string ResOpId { get; set; } = null!;

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public string? ResId { get; set; }

    public decimal? SetUpTime { get; set; }

    public decimal? ProcessingTime { get; set; }

    public int? Lotsize { get; set; }

    public decimal? SumQty { get; set; }

    public decimal? SetUpLot { get; set; }

    public decimal? FlowTime { get; set; }

    public string? OrgId { get; set; }
}
