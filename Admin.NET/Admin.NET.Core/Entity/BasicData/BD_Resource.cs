namespace Admin.NET.Core;

/// <summary>
/// 资源设备表
/// </summary>
[SugarTable(null, "资源设备表")]
[SystemTable]
public class BD_Resource : EntityBase
{
    /// <summary>
    /// 资源Id，唯一标识
    /// </summary>
    [SugarColumn(ColumnDescription = "资源Id，唯一标识", Length = 100)]
    [MaxLength(100)]
    public string ResID { get; set; }

    /// <summary>
    /// 部门Id，关联部门表
    /// </summary>
    [SugarColumn(ColumnDescription = "部门Id，关联部门表", Length = 100)]
    [MaxLength(100)]
    public string DepID { get; set; }

    /// <summary>
    /// 资源设备名称
    /// </summary>
    [SugarColumn(ColumnDescription = "资源设备名称", Length = 100)]
    [MaxLength(100)]
    public string ResName { get; set; }

    /// <summary>
    /// 设备描述
    /// </summary>
    [SugarColumn(ColumnDescription = "设备描述", Length = 500)]
    [MaxLength(100)]
    public string ResDesc { get; set; }

    /// <summary>
    /// 已弃用Status
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用Status")]
    public int? Status { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    [SugarColumn(ColumnDescription = "设备类型")]
    public int? Type { get; set; }

    /// <summary>
    /// 设备产能类型
    /// </summary>
    [SugarColumn(ColumnDescription = "设备产能类型")]
    public int? ResType { get; set; }

    /// <summary>
    /// 是否默认，默认为0
    /// </summary>
    [SugarColumn(ColumnDescription = "资源设备名称")]
    public bool IsDefault { get; set; }

    /// <summary>
    /// 工作中心编号
    /// </summary>
    [SugarColumn(ColumnDescription = "工作中心编号", Length = 100)]
    [MaxLength(100)]
    public string WorkCenterNo { get; set; }

    /// <summary>
    /// 设备数量
    /// </summary>
    [SugarColumn(ColumnDescription = "设备数量")]
    public int? Units { get; set; }

    /// <summary>
    /// 已弃用Programmable
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用Programmable")]
    public int? Programmable { get; set; }

    /// <summary>
    /// 已弃用IsSeparable
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用IsSeparable")]
    public int? IsSeparable { get; set; }

    /// <summary>
    /// 设备是否可用
    /// </summary>
    [SugarColumn(ColumnDescription = "设备是否可用")]
    public int? IsAvailable { get; set; }

    /// <summary>
    /// 是否是热处理设备(已弃用)
    /// </summary>
    [SugarColumn(ColumnDescription = "是否是热处理设备")]
    public int? IsHeattreat { get; set; }

    /// <summary>
    /// (Overtime已弃用)
    /// </summary>
    [SugarColumn(ColumnDescription = "Overtime已弃用")]
    public decimal? Overtime { get; set; }

    /// <summary>
    /// 组织编码
    /// </summary>
    [SugarColumn(ColumnDescription = "组织编码", Length = 100)]
    [MaxLength(100)]
    public string OrgID { get; set; }

    /// <summary>
    /// 加工时间
    /// </summary>
    [SugarColumn(ColumnDescription = "加工时间")]
    public decimal? ProcessTime { get; set; }

    /// <summary>
    /// 准备时间1
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间1")]
    public decimal? Setuptime1 { get; set; }

    /// <summary>
    /// 准备时间2
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间2")]
    public decimal? Setuptime2 { get; set; }

    /// <summary>
    /// 准备时间3
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间3")]
    public decimal? Setuptime3 { get; set; }

    /// <summary>
    /// 共用编码
    /// </summary>
    [SugarColumn(ColumnDescription = "共用编码", Length = 100)]
    [MaxLength(100)]
    public string VersionSign { get; set; }

    /// <summary>
    /// (isOld已弃用)
    /// </summary>
    [SugarColumn(ColumnDescription = "isOld已弃用")]
    public int? isOld { get; set; }
}
