using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FResQueueTime
{
    public string Id { get; set; } = null!;

    public string ResId { get; set; } = null!;

    public string? ResNo { get; set; }

    public decimal? MinQueue { get; set; }

    public decimal? MaxQueue { get; set; }

    public decimal? AvgQueue { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? OrgId { get; set; }

    public string? ScheduleId { get; set; }

    public int? IsAggregated { get; set; }

    public string? ResName { get; set; }
}
