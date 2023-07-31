namespace Admin.NET.Core;

/// <summary>
/// 日历信息详情表
/// </summary>
[SugarTable(null, "日历信息详情表")]
[SystemTable]
public class BD_CalendarGeneral : EntityBase
{
    /// <summary>
    /// Guid
    /// </summary>
    [SugarColumn(ColumnDescription = "Guid", Length = 100)]
    [MaxLength(100)]
    public virtual string Guid { get; set; }

    /// <summary>
    /// ResId(弃用)
    /// </summary>
    [SugarColumn(ColumnDescription = "ResId(弃用)", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResId { get; set; }

    /// <summary>
    /// ResNo
    /// </summary>
    [SugarColumn(ColumnDescription = "ResNo(弃用)", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResNo { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 日历编码
    /// </summary>
    [SugarColumn(ColumnDescription = "日历编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? CalNo { get; set; }

    /// <summary>
    /// 日历名称
    /// </summary>
    [SugarColumn(ColumnDescription = "日历名称", Length = 100)]
    [MaxLength(100)]
    public virtual string? CalName { get; set; }

    /// <summary>
    /// 可用开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "可用开始时间")]
    public virtual DateTime? BeginDate { get; set; }

    /// <summary>
    /// 可用结束时间
    /// </summary>
    [SugarColumn(ColumnDescription = "可用结束时间")]
    public virtual DateTime? EndDate { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    [SugarColumn(ColumnDescription = "备注", Length = 100)]
    [MaxLength(100)]
    public virtual string? Remark { get; set; }

    /// <summary>
    /// 工作日
    /// </summary>
    [SugarColumn(ColumnDescription = "工作日", Length = 100)]
    [MaxLength(100)]
    public virtual string? WorkDay { get; set; }

    /// <summary>
    /// 班次1
    /// </summary>
    [SugarColumn(ColumnDescription = "班次1", Length = 100)]
    [MaxLength(100)]
    public virtual string? Shift1 { get; set; }

    /// <summary>
    /// 班次2
    /// </summary>
    [SugarColumn(ColumnDescription = "班次2", Length = 100)]
    [MaxLength(100)]
    public virtual string? Shift2 { get; set; }

    /// <summary>
    /// 班次3
    /// </summary>
    [SugarColumn(ColumnDescription = "班次3", Length = 100)]
    [MaxLength(100)]
    public virtual string? Shift3 { get; set; }

    /// <summary>
    /// 日历类型
    /// </summary>
    [SugarColumn(ColumnDescription = "日历类型")]
    public virtual int? Type { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    [SugarColumn(ColumnDescription = "优先级", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Priority { get; set; }

    /// <summary>
    /// 是否默认
    /// </summary>
    [SugarColumn(ColumnDescription = "是否默认")]
    public virtual int? IsDefault { get; set; }

    /// <summary>
    /// 工作中心编码
    /// </summary>
    [SugarColumn(ColumnDescription = "工作中心编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? WorkCenterNo { get; set; }

    /// <summary>
    /// 管理日历信息表Id
    /// </summary>
    [SugarColumn(ColumnDescription = "管理日历信息表Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? CalId { get; set; }
}
