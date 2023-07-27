using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BResDayStatistic
{
    public string RdstatisticsId { get; set; } = null!;

    public string? ScheduleId { get; set; }

    public string? ResId { get; set; }

    public int? ResType { get; set; }

    public int? StatisticsType { get; set; }

    public string? OrgId { get; set; }

    public string? DepId { get; set; }

    public string? DepNo { get; set; }

    public string? DepName { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

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

    public string? WorkCenterNo { get; set; }

    public int? StaticGroupType { get; set; }
}
