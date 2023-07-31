namespace Admin.NET.Core;

/// <summary>
/// 假期日历表
/// </summary>
[SugarTable(null, "假期日历表")]
[SystemTable]
public class BD_CalHoliday : EntityBase
{
    /// <summary>
    /// HolidayId
    /// </summary>
    [SugarColumn(ColumnDescription = "HolidayId", Length = 100)]
    [MaxLength(100)]
    public virtual string HolidayId { get; set; } = null!;

    /// <summary>
    /// 假期名称
    /// </summary>
    [SugarColumn(ColumnDescription = "假期名称", Length = 100)]
    [MaxLength(100)]
    public virtual string HolidayName { get; set; } = null!;

    /// <summary>
    /// 假期描述
    /// </summary>
    [SugarColumn(ColumnDescription = "假期描述", Length = 100)]
    [MaxLength(100)]
    public virtual string? HolidayDesc { get; set; }

    /// <summary>
    /// 假期开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "假期开始时间")]
    public virtual DateTime StartTime { get; set; }

    /// <summary>
    /// 假期结束时间
    /// </summary>
    [SugarColumn(ColumnDescription = "假期结束时间")]
    public virtual DateTime StopTime { get; set; }

    /// <summary>
    /// 添加时间
    /// </summary>
    [SugarColumn(ColumnDescription = "添加时间")]
    public virtual DateTime? AddedTime { get; set; }

    /// <summary>
    /// 假期停运设备编码
    /// </summary>
    [SugarColumn(ColumnDescription = "假期停运设备编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResourceNo { get; set; }

    /// <summary>
    /// 假期停运设备名称
    /// </summary>
    [SugarColumn(ColumnDescription = "假期停运设备名称", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResourceName { get; set; }

    /// <summary>
    /// 假期类型
    /// </summary>
    [SugarColumn(ColumnDescription = "假期类型")]
    public virtual int Type { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 日历信息表Id(弃用)
    /// </summary>
    [SugarColumn(ColumnDescription = "日历信息表Id(弃用)", Length = 100)]
    [MaxLength(100)]
    public virtual string? CalId { get; set; }

    /// <summary>
    /// 休息总时长
    /// </summary>
    [SugarColumn(ColumnDescription = "休息总时长", Length = 18, DecimalDigits = 6)]
    public virtual decimal? DownTime { get; set; }
}
