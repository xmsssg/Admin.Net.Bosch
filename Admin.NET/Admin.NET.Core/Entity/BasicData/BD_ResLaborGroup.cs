using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BResLaborGroup
{
    public string ResId { get; set; } = null!;

    public string LaborGroupId { get; set; } = null!;

    public decimal? DefaultSkill { get; set; }

    public int? Priority { get; set; }

    public int? DefaultOpLaborQty { get; set; }

    public bool? IsActive { get; set; }

    public string ResLaborId { get; set; } = null!;

    public string? OrgId { get; set; }
}
