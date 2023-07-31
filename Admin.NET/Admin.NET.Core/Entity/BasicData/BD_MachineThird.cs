namespace Admin.NET.Core;

/// <summary>
/// 换型矩阵表
/// </summary>
[SugarTable(null, "换型矩阵表")]
[SystemTable]
public class BD_MachineThird : EntityBase
{
    /// <summary>
    /// 分组编码
    /// </summary>
    [SugarColumn(ColumnDescription = "分组编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? GroupNo { get; set; }

    /// <summary>
    /// 分组描述
    /// </summary>
    [SugarColumn(ColumnDescription = "分组描述", Length = 100)]
    [MaxLength(100)]
    public virtual string? GroupDesc { get; set; }

    /// <summary>
    /// 设备编码
    /// </summary>
    [SugarColumn(ColumnDescription = "设备编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? ResNo { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 分组类型
    /// </summary>
    [SugarColumn(ColumnDescription = "分组类型")]
    public virtual int? MachineType { get; set; }

    /// <summary>
    /// 压机属性(单料/双料)
    /// </summary>
    [SugarColumn(ColumnDescription = "压机属性(单料/双料)")]
    public virtual int? Maetype { get; set; }
}
