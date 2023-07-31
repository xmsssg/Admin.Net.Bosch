using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWhatifOpRe
{
    public string OpResId { get; set; } = null!;

    public string? PartId { get; set; }

    public string? Bomid { get; set; }

    public string? OpId { get; set; }

    public string? ResId { get; set; }

    public decimal? Setuptime { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ProcessTime { get; set; }

    public decimal? Priority { get; set; }

    public int? Enabled { get; set; }

    public int? Uom { get; set; }

    public double? SetupQuantity { get; set; }

    public decimal? Queuetime { get; set; }

    public int? RequiredLaborQty { get; set; }

    public string? PloresGroupId { get; set; }

    public decimal? AssignedUnits { get; set; }

    public string? OrgId { get; set; }

    public decimal? ResMaxCapacity { get; set; }
}
