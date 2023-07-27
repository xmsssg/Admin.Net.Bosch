namespace Admin.NET.Core;

/// <summary>
/// 资源设备表
/// </summary>
[SugarTable(null, "资源设备表")]
[SystemTable]
public partial class BD_Line : EntityBase
{

    /// <summary>
    /// 拉线编码
    /// </summary>
    [SugarColumn(ColumnDescription = "拉线编码", Length = 100)]
    [MaxLength(100)]
    public string? LineNo { get; set; }

    /// <summary>
    /// 类型
    /// </summary>
    [SugarColumn(ColumnDescription = "类型", Length = 100)]
    [MaxLength(100)]
    public string? Type { get; set; }

    /// <summary>
    /// 所属部门
    /// </summary>
    [SugarColumn(ColumnDescription = "所属部门", Length = 100)]
    [MaxLength(100)]
    public string? DeptId { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    [SugarColumn(ColumnDescription = "是否可用")]
    public int? IsAvailable { get; set; }

    /// <summary>
    /// 生效时间
    /// </summary>
    [SugarColumn(ColumnDescription = "生效时间")]
    public DateTime? TakeEffectTime { get; set; }

    /// <summary>
    /// 失效时间
    /// </summary>
    [SugarColumn(ColumnDescription = "失效时间")]
    public DateTime? InvalidTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    [SugarColumn(ColumnDescription = "修改时间")]
    public DateTime? UpdateTime { get; set; }
}
