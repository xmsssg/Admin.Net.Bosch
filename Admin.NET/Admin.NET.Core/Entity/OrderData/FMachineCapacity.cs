using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FMachineCapacity
{
    public string Id { get; set; } = null!;

    public string? ResNo { get; set; }

    public string? ScheduleId { get; set; }

    public int? WorkType { get; set; }

    public DateTime? StarTime { get; set; }

    public DateTime? StopTime { get; set; }

    public decimal? Capacity { get; set; }

    public DateTime? SchStartTime { get; set; }

    public int? IsWork { get; set; }

    public DateTime? FillCapacityTime { get; set; }
}
