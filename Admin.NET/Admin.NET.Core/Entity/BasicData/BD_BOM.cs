namespace Admin.NET.Core;

/// <summary>
/// BOM表
/// </summary>
[SugarTable(null, "BOM表")]
[SystemTable]
public class BD_BOM : EntityBase
{
    /// <summary>
    /// BOMId
    /// </summary>
    [SugarColumn(ColumnDescription = "BOMId", Length = 100)]
    [MaxLength(100)]
    public virtual string BomId { get; set; }

    /// <summary>
    /// 组织Id
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 主产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "主产品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? MasterPartId { get; set; }

    /// <summary>
    /// 子产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "主产品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? SubPartId { get; set; }

    /// <summary>
    /// 根产成品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "根产成品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? RootPartId { get; set; }

    /// <summary>
    /// 比例
    /// </summary>
    [SugarColumn(ColumnDescription = "比例", Length = 18, DecimalDigits = 6)]
    public virtual decimal? NeedQty { get; set; }

    /// <summary>
    /// 子产品类型
    /// </summary>
    [SugarColumn(ColumnDescription = "子产品类型")]
    public virtual int? SubProductType { get; set; }

    /// <summary>
    /// 层级
    /// </summary>
    [SugarColumn(ColumnDescription = "层级")]
    public virtual int? Level { get; set; }

    /// <summary>
    /// 图纸链接
    /// </summary>
    [SugarColumn(ColumnDescription = "图纸链接", Length = 100)]
    [MaxLength(100)]
    public virtual string? BomPath { get; set; }

    /// <summary>
    /// 对应工序
    /// </summary>
    [SugarColumn(ColumnDescription = "对应工序", Length = 100)]
    [MaxLength(100)]
    public virtual string? OpNo { get; set; }

    /// <summary>
    /// 上层BOM Id
    /// </summary>
    [SugarColumn(ColumnDescription = "上层BOM Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? UpperLayerBomid { get; set; }

    /// <summary>
    /// PartBomId
    /// </summary>
    [SugarColumn(ColumnDescription = "PartBomId", Length = 100)]
    [MaxLength(100)]
    public virtual string? PartBomId { get; set; }

    /// <summary>
    /// 子产品层级
    /// </summary>
    [SugarColumn(ColumnDescription = "子产品层级", Length = 100)]
    [MaxLength(100)]
    public virtual string? Slevel { get; set; }

    /// <summary>
    /// 主产品层级
    /// </summary>
    [SugarColumn(ColumnDescription = "主产品层级", Length = 100)]
    [MaxLength(100)]
    public virtual string? Mlevel { get; set; }

    /// <summary>
    /// 主产品类型
    /// </summary>
    [SugarColumn(ColumnDescription = "主产品类型")]
    public virtual int? MasterPartType { get; set; }

    /// <summary>
    /// 子产品类型
    /// </summary>
    [SugarColumn(ColumnDescription = "子产品类型")]
    public virtual int? SubPartType { get; set; }

    /// <summary>
    /// 可用开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "子产品类型")]
    public virtual DateTime? StartTime { get; set; }

    /// <summary>
    /// 可用结束时间
    /// </summary>
    [SugarColumn(ColumnDescription = "子产品类型")]
    public virtual DateTime? StopTime { get; set; }

    /// <summary>
    /// 可用产线
    /// </summary>
    [SugarColumn(ColumnDescription = "子产品类型", Length = 100)]
    [MaxLength(100)]
    public virtual string? AvailableLine { get; set; }
}
