using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BAreaMaximun
{
    public string AreaId { get; set; }

    public string? WeekMaximunId { get; set; }

    public string? Area { get; set; }

    public decimal? DemQty { get; set; }

    public string? OrgId { get; set; }
}
