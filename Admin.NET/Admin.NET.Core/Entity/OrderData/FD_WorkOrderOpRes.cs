namespace Admin.NET.Core;

/// <summary>
/// 工单工序资源设备表
/// </summary>
[SugarTable(null, "工单工序资源设备表")]
[SystemTable]

public class FD_WorkOrderOpRes : EntityBase
{
    /// <summary>
    /// WoopResId(工单工序资源设备表Id)
    /// </summary>
    [SugarColumn(ColumnDescription = "WoopResId(工单工序资源设备表Id)", Length = 100)]
    [MaxLength(100)]
    public virtual string WoopResId { get; set; } 

    /// <summary>
    /// WoopId(工单工序表Id)
    /// </summary>
    [SugarColumn(ColumnDescription = "WoopId(工单工序表Id)", Length = 100)]
    [MaxLength(100)]
    public virtual string? WoopId { get; set; }

    /// <summary>
    /// 资源设备Id
    /// </summary>
    [SugarColumn(ColumnDescription = "资源设备Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResId { get; set; }

    /// <summary>
    /// 资源设备速率
    /// </summary>
    [SugarColumn(ColumnDescription = "资源设备速率", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Setuptime { get; set; }

    /// <summary>
    /// 资源设备速率
    /// </summary>
    [SugarColumn(ColumnDescription = "资源设备速率", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Rate { get; set; }

    /// <summary>
    /// 加工时间
    /// </summary>
    [SugarColumn(ColumnDescription = "加工时间", Length = 18, DecimalDigits = 6)]
    public virtual decimal? ProcessTime { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    [SugarColumn(ColumnDescription = "优先级", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Priority { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    [SugarColumn(ColumnDescription = "是否可用")]
    public virtual int? Enabled { get; set; }

    /// <summary>
    /// 加工结束时间
    /// </summary>
    [SugarColumn(ColumnDescription = "加工结束时间")]
    public virtual DateTime? PlanStartTime { get; set; }

    /// <summary>
    /// 加工开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "加工开始时间")]
    public virtual DateTime? PlanStopTime { get; set; }

    /// <summary>
    /// 排程数量
    /// </summary>
    [SugarColumn(ColumnDescription = "排程数量")]
    public virtual int? PlanQty { get; set; }

    /// <summary>
    /// 准备数量
    /// </summary>
    [SugarColumn(ColumnDescription = "准备数量")]
    public virtual int? SetupQty { get; set; }

    /// <summary>
    /// 是否指定分配
    /// </summary>
    [SugarColumn(ColumnDescription = "是否指定分配")]
    public virtual bool Assigned { get; set; }

    /// <summary>
    /// 是否准许
    /// </summary>
    [SugarColumn(ColumnDescription = "是否准许")]
    public virtual bool? NotAllowed { get; set; }

    /// <summary>
    /// 等待时间
    /// </summary>
    [SugarColumn(ColumnDescription = "Guid", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Queuetime { get; set; }

    /// <summary>
    /// Guid
    /// </summary>
    [SugarColumn(ColumnDescription = "Guid", Length = 18, DecimalDigits = 6)]
    public virtual decimal? SetupAppliedHours { get; set; }

    /// <summary>
    /// 准备时间时间
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间时间", Length = 18, DecimalDigits = 6)]
    public virtual decimal? RunAppliedHours { get; set; }

    /// <summary>
    /// 资源组Id
    /// </summary>
    [SugarColumn(ColumnDescription = "资源组Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResGroupId { get; set; }

    /// <summary>
    /// 所需人力数
    /// </summary>
    [SugarColumn(ColumnDescription = "所需人力数")]
    public virtual int? RequiredLaborQty { get; set; }

    /// <summary>
    /// 用户是否明确
    /// </summary>
    [SugarColumn(ColumnDescription = "用户是否明确")]
    public virtual bool? IsUserDefined { get; set; }

    /// <summary>
    /// 分配单位
    /// </summary>
    [SugarColumn(ColumnDescription = "分配单位", Length = 18, DecimalDigits = 6)]
    public virtual decimal? AssignedUnits { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// Setuptime2
    /// </summary>
    [SugarColumn(ColumnDescription = "Setuptime2", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Setuptime2 { get; set; }

    /// <summary>
    /// Setuptime3
    /// </summary>
    [SugarColumn(ColumnDescription = "Setuptime3", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Setuptime3 { get; set; }

    /// <summary>
    /// 工序编码
    /// </summary>
    [SugarColumn(ColumnDescription = "工序编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? OpNo { get; set; }

    /// <summary>
    /// 资源设备编码
    /// </summary>
    [SugarColumn(ColumnDescription = "资源设备编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? Resno { get; set; }

    /// <summary>
    /// 工单Id
    /// </summary>
    [SugarColumn(ColumnDescription = "工单Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? WorkOrderId { get; set; }
}
