namespace Admin.NET.Core;

/// <summary>
/// 调度信息表
/// </summary>
[SugarTable(null, "调度信息表")]
[SystemTable]
public class FD_Schedule : EntityBase
{
    /// <summary>
    /// 调度Id
    /// </summary>
    [SugarColumn(ColumnDescription = "调度Id", Length = 100)]
    [MaxLength(100)]
    public virtual string ScheduleId { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 调度编码
    /// </summary>
    [SugarColumn(ColumnDescription = "调度编码", Length = 100)]
    [MaxLength(100)]
    public virtual string ScheduleNo { get; set; }

    /// <summary>
    /// 调度名称
    /// </summary>
    [SugarColumn(ColumnDescription = "调度名称", Length = 100)]
    [MaxLength(100)]
    public virtual string? ScheduleName { get; set; }

    /// <summary>
    /// 调度描述
    /// </summary>
    [SugarColumn(ColumnDescription = "调度描述", Length = 100)]
    [MaxLength(100)]
    public virtual string? ScheduleDesc { get; set; }

    /// <summary>
    /// 是否完成
    /// </summary>
    [SugarColumn(ColumnDescription = "是否完成")]
    public virtual int? IsConfirmed { get; set; }

    /// <summary>
    /// ScheduleTarget
    /// </summary>
    [SugarColumn(ColumnDescription = "ScheduleTarget")]
    public virtual int? ScheduleTarget { get; set; }

    /// <summary>
    /// 调度开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "调度开始时间")]
    public virtual DateTime? ScheduleStartTime { get; set; }

    /// <summary>
    /// 锁定天数
    /// </summary>
    [SugarColumn(ColumnDescription = "锁定天数")]
    public virtual int? FrozenDays { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    [SugarColumn(ColumnDescription = "完成时间")]
    public virtual DateTime? ConfirmTime { get; set; }

    /// <summary>
    /// 取消时间
    /// </summary>
    [SugarColumn(ColumnDescription = "取消时间")]
    public virtual DateTime? CancelConfirmTime { get; set; }

    /// <summary>
    /// 参数
    /// </summary>
    [SugarColumn(ColumnDescription = "参数", Length = 100)]
    [MaxLength(100)]
    public virtual string? Parameters { get; set; }

    /// <summary>
    /// 调度作业数
    /// </summary>
    [SugarColumn(ColumnDescription = "调度作业数")]
    public virtual int? ScheduledJobsCount { get; set; }

    /// <summary>
    /// 调度产品总数
    /// </summary>
    [SugarColumn(ColumnDescription = "调度产品总数")]
    public virtual int? ScheduledPartsCount { get; set; }

    /// <summary>
    /// 调度作业总数
    /// </summary>
    [SugarColumn(ColumnDescription = "调度作业总数")]
    public virtual int? LateJobsCount { get; set; }

    /// <summary>
    /// 正在执行作业总数
    /// </summary>
    [SugarColumn(ColumnDescription = "正在执行作业总数")]
    public virtual int? OnTimeJobsCount { get; set; }

    /// <summary>
    /// 平均延迟天数
    /// </summary>
    [SugarColumn(ColumnDescription = "平均延迟天数", Length = 18, DecimalDigits = 6)]
    public virtual decimal? AverageDelay { get; set; }

    /// <summary>
    /// 平均提前完成天数
    /// </summary>
    [SugarColumn(ColumnDescription = "平均提前完成天数", Length = 18, DecimalDigits = 6)]
    public virtual decimal? AverageLeadtime { get; set; }

    /// <summary>
    /// 最大延迟天数
    /// </summary>
    [SugarColumn(ColumnDescription = "最大延迟天数", Length = 18, DecimalDigits = 6)]
    public virtual decimal? MaxDelay { get; set; }

    /// <summary>
    /// 最小延迟天数
    /// </summary>
    [SugarColumn(ColumnDescription = "最小延迟天数", Length = 18, DecimalDigits = 6)]
    public virtual decimal? MinDelay { get; set; }

    /// <summary>
    /// 最大提前天数
    /// </summary>
    [SugarColumn(ColumnDescription = "最大提前天数", Length = 18, DecimalDigits = 6)]
    public virtual decimal? MaxLeadtime { get; set; }

    /// <summary>
    /// 最小提前天数
    /// </summary>
    [SugarColumn(ColumnDescription = "最小提前天数", Length = 18, DecimalDigits = 6)]
    public virtual decimal? MinLeadtime { get; set; }

    /// <summary>
    /// 生产周期
    /// </summary>
    [SugarColumn(ColumnDescription = "生产周期", Length = 18,DecimalDigits =6)]
    public virtual decimal? ProductionSpan { get; set; }

    /// <summary>
    /// AverageDailyWip
    /// </summary>
    [SugarColumn(ColumnDescription = "部门Id", Length = 18, DecimalDigits = 6)]
    [MaxLength(100)]
    public virtual decimal? AverageDailyWip { get; set; }

    /// <summary>
    /// 生产作业总数
    /// </summary>
    [SugarColumn(ColumnDescription = "生产作业总数")]
    public virtual int? ProductedJobsCount { get; set; }

    /// <summary>
    /// 平均生产周期
    /// </summary>
    [SugarColumn(ColumnDescription = "平均生产周期", Length = 18,DecimalDigits =6)]
    public virtual decimal? AvgProductionPeriod { get; set; }

    /// <summary>
    /// 优化目标1
    /// </summary>
    [SugarColumn(ColumnDescription = "优化目标1")]
    public virtual int? OptimizationObjective1 { get; set; }

    /// <summary>
    /// 优化目标2
    /// </summary>
    [SugarColumn(ColumnDescription = "优化目标2")]
    public virtual int? OptimizationObjective2 { get; set; }

    /// <summary>
    /// 最大作业周期
    /// </summary>
    [SugarColumn(ColumnDescription = "最大作业周期", Length = 18,DecimalDigits =6)]
    public virtual decimal? MaxJobLife { get; set; }

    /// <summary>
    /// 平均作业周期
    /// </summary>
    [SugarColumn(ColumnDescription = "平均作业周期", Length = 18, DecimalDigits = 6)]
    public virtual decimal? AvgJobLife { get; set; }

    /// <summary>
    /// 用户Id
    /// </summary>
    [SugarColumn(ColumnDescription = "用户Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? UserId { get; set; }

    /// <summary>
    /// ScheduleClass默认值1
    /// </summary>
    [SugarColumn(ColumnDescription = "ScheduleClass默认值1")]
    public virtual int? ScheduleClass { get; set; }

    /// <summary>
    /// 调度类型默认值2
    /// </summary>
    [SugarColumn(ColumnDescription = "调度类型默认值2")]
    public virtual int? Type { get; set; }
}
