using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BDownTime
{
    public string DownTimeId { get; set; } = null!;

    public string DownTimeNo { get; set; } = null!;

    public string? DownTimeDesc { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime StopTime { get; set; }

    public decimal? DownTime { get; set; }

    public string? OrgId { get; set; }

    public string? Weekday { get; set; }
}
