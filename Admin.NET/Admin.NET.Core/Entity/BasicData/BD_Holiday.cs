using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BHoliday
{
    public string HolidayId { get; set; } = null!;

    public string HolidayName { get; set; } = null!;

    public string? HolidayDesc { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime StopTime { get; set; }

    public string? OrgId { get; set; }
}
