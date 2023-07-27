namespace Admin.NET.Core;

/// <summary>
/// 工序设备明细表(Sch)
/// </summary>
[SugarTable(null, "工序设备明细表(Sch)")]
[SystemTable]
public class BD_OpRes : EntityBase
{
    /// <summary>
    /// 工序设备Id
    /// </summary>
    [SugarColumn(ColumnDescription = "工序设备Id", Length = 100)]
    [MaxLength(100)]
    public string OpResId { get; set; }

    /// <summary>
    /// 产品id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品id", Length = 100)]
    [MaxLength(100)]
    public string? PartId { get; set; }

    /// <summary>
    /// BOMId
    /// </summary>
    [SugarColumn(ColumnDescription = "BOMId", Length = 100)]
    [MaxLength(100)]
    public string? Bomid { get; set; }

    /// <summary>
    /// 工序Id
    /// </summary>
    [SugarColumn(ColumnDescription = "工序Id", Length = 100)]
    [MaxLength(100)]
    public string? OpId { get; set; }

    /// <summary>
    /// 设备Id
    /// </summary>
    [SugarColumn(ColumnDescription = "设备Id", Length = 100)]
    [MaxLength(100)]
    public string? ResId { get; set; }

    /// <summary>
    /// 准备时间(PT)
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间(PT)", Length = 100)]
    [MaxLength(100)]
    public decimal? Setuptime { get; set; }

    /// <summary>
    /// 速率
    /// </summary>
    [SugarColumn(ColumnDescription = "速率", Length = 100)]
    [MaxLength(100)]
    public decimal? Rate { get; set; }

    /// <summary>
    /// 加工时间(MT)
    /// </summary>
    [SugarColumn(ColumnDescription = "加工时间(MT)", Length = 100)]
    [MaxLength(100)]
    public decimal? ProcessTime { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    [SugarColumn(ColumnDescription = "优先级", Length = 100)]
    [MaxLength(100)]
    public decimal? Priority { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    [SugarColumn(ColumnDescription = "是否可用", Length = 100)]
    [MaxLength(100)]
    public int? Enabled { get; set; }

    /// <summary>
    /// Uom
    /// </summary>
    [SugarColumn(ColumnDescription = "Uom", Length = 100)]
    [MaxLength(100)]
    public int? Uom { get; set; }

    /// <summary>
    /// 准备数量
    /// </summary>
    [SugarColumn(ColumnDescription = "准备数量", Length = 100)]
    [MaxLength(100)]
    public double? SetupQuantity { get; set; }

    /// <summary>
    /// 排队时间
    /// </summary>
    [SugarColumn(ColumnDescription = "排队时间", Length = 100)]
    [MaxLength(100)]
    public decimal? Queuetime { get; set; }

    /// <summary>
    /// 所需人工数量
    /// </summary>
    [SugarColumn(ColumnDescription = "所需人工数量", Length = 100)]
    [MaxLength(100)]
    public int? RequiredLaborQty { get; set; }

    /// <summary>
    /// PloresGroupId
    /// </summary>
    [SugarColumn(ColumnDescription = "PloresGroupId", Length = 100)]
    [MaxLength(100)]
    public string? PloresGroupId { get; set; }

    /// <summary>
    /// 分配单位
    /// </summary>
    [SugarColumn(ColumnDescription = "分配单位", Length = 100)]
    [MaxLength(100)]
    public decimal? AssignedUnits { get; set; }

    /// <summary>
    /// 组织Id
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 100)]
    [MaxLength(100)]
    public string? OrgId { get; set; }

    /// <summary>
    /// 最大产能
    /// </summary>
    [SugarColumn(ColumnDescription = "最大产能", Length = 100)]
    [MaxLength(100)]
    public decimal? ResMaxCapacity { get; set; }

    /// <summary>
    /// 准备时间（ST）
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间（ST）", Length = 100)]
    [MaxLength(100)]
    public decimal? Setuptime2 { get; set; }

    /// <summary>
    /// 工序Id
    /// </summary>
    [SugarColumn(ColumnDescription = "工序Id", Length = 100)]
    [MaxLength(100)]
    public decimal? Setuptime3 { get; set; }

    /// <summary>
    /// 工序编码
    /// </summary>
    [SugarColumn(ColumnDescription = "工序编码", Length = 100)]
    [MaxLength(100)]
    public string? Opno { get; set; }
}
