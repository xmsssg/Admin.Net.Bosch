using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FDepDayStatistic
{
    public string RdstatisticsId { get; set; } = null!;

    public string? ScheduleId { get; set; }

    public int? ResOrLabor { get; set; }

    public int? StatisticsType { get; set; }

    public string? OrgId { get; set; }

    public string? DepId { get; set; }

    public string? DepNo { get; set; }

    public string? DepName { get; set; }

    public DateTime? DayInfo { get; set; }

    public decimal? TotalCalenderHours { get; set; }

    public decimal? TotalStandardHours { get; set; }

    public decimal? TotalScheduleHours { get; set; }

    public decimal? TotalAppliedHours { get; set; }

    public decimal? TotalScheduleHoursD { get; set; }

    public decimal? TotalScheduleHoursC { get; set; }

    public decimal? TotalPlohours { get; set; }

    public decimal? TotalUnReleasedHours { get; set; }

    public decimal? TotalIncomingHours { get; set; }
}
