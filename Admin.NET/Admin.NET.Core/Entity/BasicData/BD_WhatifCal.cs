using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWhatifCal
{
    public string CalId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string CalNo { get; set; } = null!;

    public string? CalName { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Remark { get; set; }

    public int? Type { get; set; }

    public decimal? Priority { get; set; }

    public decimal? ResId { get; set; }

    public int? IsDefault { get; set; }
}
