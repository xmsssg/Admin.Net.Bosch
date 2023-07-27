namespace Admin.NET.Core;

/// <summary>
/// 订单表
/// </summary>
[SugarTable(null, "订单表")]
[SystemTable]
public class FD_SoLine : EntityBase
{
    /// <summary>
    /// Guid
    /// </summary>
    [SugarColumn(ColumnDescription = "Guid", Length = 100)]
    [MaxLength(100)]
    public virtual string Guid { get; set; } 

    /// <summary>
    /// 订单Id
    /// </summary>
    [SugarColumn(ColumnDescription = "订单Id", Length = 100)]
    [MaxLength(100)]
    public virtual string SolineId { get; set; } 

    /// <summary>
    /// 订单编码
    /// </summary>
    [SugarColumn(ColumnDescription = "订单编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolineNo { get; set; }

    /// <summary>
    /// 订单状态
    /// </summary>
    [SugarColumn(ColumnDescription = "订单状态", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolineStatus { get; set; }

    /// <summary>
    /// 下单产品编码
    /// </summary>
    [SugarColumn(ColumnDescription = "下单产品编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolinePartNo { get; set; }

    /// <summary>
    /// 下单产品描述
    /// </summary>
    [SugarColumn(ColumnDescription = "下单产品描述", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolinePartDesc { get; set; }

    /// <summary>
    /// 客户名称
    /// </summary>
    [SugarColumn(ColumnDescription = "客户名称", Length = 100)]
    [MaxLength(100)]
    public virtual string? CustomerName { get; set; }

    /// <summary>
    /// 交期
    /// </summary>
    [SugarColumn(ColumnDescription = "交期")]
    public virtual DateTime? SodueDate { get; set; }

    /// <summary>
    /// Soid
    /// </summary>
    [SugarColumn(ColumnDescription = "Soid", Length = 100)]
    [MaxLength(100)]
    public virtual string? Soid { get; set; }

    /// <summary>
    /// 订单编码
    /// </summary>
    [SugarColumn(ColumnDescription = "订单编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? Sono { get; set; }

    /// <summary>
    /// SoheaderType
    /// </summary>
    [SugarColumn(ColumnDescription = "SoheaderType", Length = 100)]
    [MaxLength(100)]
    public virtual string? SoheaderType { get; set; }

    /// <summary>
    /// Sostatus
    /// </summary>
    [SugarColumn(ColumnDescription = "Sostatus", Length = 100)]
    [MaxLength(100)]
    public virtual string? Sostatus { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 订单开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "订单开始时间")]
    public virtual DateTime? PlanStartTime { get; set; }

    /// <summary>
    /// 订单结束时间
    /// </summary>
    [SugarColumn(ColumnDescription = "订单结束时间")]
    public virtual DateTime? PlanStopTime { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    [SugarColumn(ColumnDescription = "优先级", Length = 18,DecimalDigits =6)]
    public virtual decimal? Priority { get; set; }

    /// <summary>
    /// 集成用户Id
    /// </summary>
    [SugarColumn(ColumnDescription = "集成用户Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? IntegUserId { get; set; }

    /// <summary>
    /// 集成时间
    /// </summary>
    [SugarColumn(ColumnDescription = "集成时间")]
    public virtual DateTime? IntegTime { get; set; }

    /// <summary>
    /// 延期天数
    /// </summary>
    [SugarColumn(ColumnDescription = "延期天数", Length = 18,DecimalDigits =6)]
    public virtual decimal? Delay { get; set; }

    /// <summary>
    /// 生产代码PlannerCode
    /// </summary>
    [SugarColumn(ColumnDescription = "生产代码PlannerCode", Length = 100)]
    [MaxLength(100)]
    public virtual string? PlannerCode { get; set; }

    /// <summary>
    /// 制造组Mfggroup
    /// </summary>
    [SugarColumn(ColumnDescription = "制造组Mfggroup", Length = 100)]
    [MaxLength(100)]
    public virtual string? Mfggroup { get; set; }

    /// <summary>
    /// 订单数量
    /// </summary>
    [SugarColumn(ColumnDescription = "订单数量", Length = 18,DecimalDigits =6)]
    public virtual decimal? DemQty { get; set; }

    /// <summary>
    /// 发货日期
    /// </summary>
    [SugarColumn(ColumnDescription = "发货日期")]
    public virtual DateTime? MrpshipDate { get; set; }

    /// <summary>
    /// 预计发货时间
    /// </summary>
    [SugarColumn(ColumnDescription = "预计发货时间")]
    public virtual DateTime? EstimatedShipDate { get; set; }

    /// <summary>
    /// Nov预计发货时间
    /// </summary>
    [SugarColumn(ColumnDescription = "Nov预计发货时间")]
    public virtual DateTime? NovestimatedShipDate { get; set; }

    /// <summary>
    /// 最早可开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "最早可开始时间")]
    public virtual DateTime? Est { get; set; }

    /// <summary>
    /// 是否是预测单
    /// </summary>
    [SugarColumn(ColumnDescription = "是否是预测单")]
    public virtual bool? IsForecast { get; set; }

    /// <summary>
    /// SolineState
    /// </summary>
    [SugarColumn(ColumnDescription = "SolineState", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolineState { get; set; }

    /// <summary>
    /// IsSplited
    /// </summary>
    [SugarColumn(ColumnDescription = "IsSplited")]
    public virtual int? IsSplited { get; set; }

    /// <summary>
    /// 现货数量
    /// </summary>
    [SugarColumn(ColumnDescription = "现货数量")]
    public virtual int? FromStock { get; set; }

    /// <summary>
    /// 订单类型
    /// </summary>
    [SugarColumn(ColumnDescription = "订单类型", Length = 100)]
    [MaxLength(100)]
    public virtual string? Type { get; set; }

    /// <summary>
    /// 区域
    /// </summary>
    [SugarColumn(ColumnDescription = "区域", Length = 100)]
    [MaxLength(100)]
    public virtual string? Region { get; set; }

    /// <summary>
    /// 卖家
    /// </summary>
    [SugarColumn(ColumnDescription = "销售至", Length = 100)]
    [MaxLength(100)]
    public virtual string? Soldto { get; set; }

    /// <summary>
    /// 卖家名称
    /// </summary>
    [SugarColumn(ColumnDescription = "Soldtoname", Length = 100)]
    [MaxLength(100)]
    public virtual string? Soldtoname { get; set; }

    /// <summary>
    /// 收货人
    /// </summary>
    [SugarColumn(ColumnDescription = "收货人", Length = 100)]
    [MaxLength(100)]
    public virtual string? Shipto { get; set; }

    /// <summary>
    /// 收货人名称
    /// </summary>
    [SugarColumn(ColumnDescription = "收货人名称", Length = 100)]
    [MaxLength(100)]
    public virtual string? Shiptoname { get; set; }

    /// <summary>
    /// 城市
    /// </summary>
    [SugarColumn(ColumnDescription = "城市", Length = 100)]
    [MaxLength(100)]
    public virtual string? City { get; set; }

    /// <summary>
    /// 规则
    /// </summary>
    [SugarColumn(ColumnDescription = "规则", Length = 100)]
    [MaxLength(100)]
    public virtual string? Incoterms { get; set; }

    /// <summary>
    /// 客户联络方式
    /// </summary>
    [SugarColumn(ColumnDescription = "客户联络方式", Length = 100)]
    [MaxLength(100)]
    public virtual string? CustomerContactWindow { get; set; }

    /// <summary>
    /// 锁定期
    /// </summary>
    [SugarColumn(ColumnDescription = "锁定期", Length = 18,DecimalDigits =6)]
    public virtual decimal? FrozenZoneDay { get; set; }

    /// <summary>
    /// 差异Difference
    /// </summary>
    [SugarColumn(ColumnDescription = "差异Difference", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Difference { get; set; }

    /// <summary>
    /// 产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? PartId { get; set; }

    /// <summary>
    /// 是否是原始订单
    /// </summary>
    [SugarColumn(ColumnDescription = "是否是原始订单")]
    public virtual int? IsOriginal { get; set; }
}
