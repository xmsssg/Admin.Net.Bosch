using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWeekMaximun
{
    public string WeekMaximunId { get; set; } = null!;

    public decimal? Maximumoutput { get; set; }

    public int? OrderNo { get; set; }

    public string? OrgId { get; set; }
}
