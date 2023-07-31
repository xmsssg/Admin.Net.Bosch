namespace Admin.NET.Core;

/// <summary>
/// 设备日历信息表
/// </summary>
[SugarTable(null, "设备日历信息表")]
[SystemTable]
public class BD_ResCal
{
    /// <summary>
    /// 设备Id
    /// </summary>
    [SugarColumn(ColumnDescription = "设备Id", Length = 100)]
    [MaxLength(100)]
    public virtual string ResId { get; set; }

    /// <summary>
    /// 日历Id
    /// </summary>
    [SugarColumn(ColumnDescription = "日历Id", Length = 100)]
    [MaxLength(100)]
    public virtual string CalId { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    [SugarColumn(ColumnDescription = "优先级")]
    public virtual int? Priority { get; set; }

    /// <summary>
    /// 组织Id
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// CalResId
    /// </summary>
    [SugarColumn(ColumnDescription = "CalResId", Length = 100)]
    [MaxLength(100)]
    public virtual string CalResId { get; set; }
}
