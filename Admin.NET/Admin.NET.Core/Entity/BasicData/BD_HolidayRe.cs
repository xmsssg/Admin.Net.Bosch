using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BHolidayRe
{
    public string HolidayResId { get; set; } = null!;

    public string HolidayId { get; set; } = null!;

    public string ResId { get; set; } = null!;

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public string? OrgId { get; set; }
}
