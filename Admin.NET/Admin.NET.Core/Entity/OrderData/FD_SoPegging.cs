namespace Admin.NET.Core;

/// <summary>
/// 订单表
/// </summary>
[SugarTable(null, "订单表")]
[SystemTable]
public class FD_SoPegging : EntityBase
{
    /// <summary>
    /// Guid
    /// </summary>
    [SugarColumn(ColumnDescription = "Guid", Length = 100)]
    [MaxLength(100)]
    public virtual string Guid { get; set; }

    /// <summary>
    /// PegId
    /// </summary>
    [SugarColumn(ColumnDescription = "PegId", Length = 100)]
    [MaxLength(100)]
    public virtual string? PegId { get; set; }

    /// <summary>
    /// PrePegId
    /// </summary>
    [SugarColumn(ColumnDescription = "PrePegId", Length = 100)]
    [MaxLength(100)]
    public virtual string? PrePegId { get; set; }

    /// <summary>
    /// RootPegId
    /// </summary>
    [SugarColumn(ColumnDescription = "RootPegId", Length = 100)]
    [MaxLength(100)]
    public virtual string? RootPegId { get; set; }

    /// <summary>
    /// PegLevel
    /// </summary>
    [SugarColumn(ColumnDescription = "PegLevel")]
    public virtual int? PegLevel { get; set; }

    /// <summary>
    /// SortOrder
    /// </summary>
    [SugarColumn(ColumnDescription = "SortOrder", Length = 100)]
    [MaxLength(100)]
    public virtual string? SortOrder { get; set; }

    /// <summary>
    /// OutputLevel
    /// </summary>
    [SugarColumn(ColumnDescription = "OutputLevel", Length = 100)]
    [MaxLength(100)]
    public virtual string? OutputLevel { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    [SugarColumn(ColumnDescription = "数量")]
    public virtual int? DemQty { get; set; }

    /// <summary>
    /// SupQty
    /// </summary>
    [SugarColumn(ColumnDescription = "GSupQtyuid")]
    public virtual int? SupQty { get; set; }

    /// <summary>
    /// 已分配数量
    /// </summary>
    [SugarColumn(ColumnDescription = "已分配数量")]
    public virtual int? AllocatedQty { get; set; }

    /// <summary>
    /// 产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? PartId { get; set; }

    /// <summary>
    /// 客户名称
    /// </summary>
    [SugarColumn(ColumnDescription = "客户名称", Length = 100)]
    [MaxLength(100)]
    public virtual string? CustomerName { get; set; }

    /// <summary>
    /// 订单交期
    /// </summary>
    [SugarColumn(ColumnDescription = "订单交期", Length = 100)]
    [MaxLength(100)]
    public virtual DateTime? SodueDate { get; set; }

    /// <summary>
    /// 订单Soid
    /// </summary>
    [SugarColumn(ColumnDescription = "订单Soid", Length = 100)]
    [MaxLength(100)]
    public virtual string? Soid { get; set; }

    /// <summary>
    /// 订单Sono
    /// </summary>
    [SugarColumn(ColumnDescription = "订单Sono", Length = 100)]
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
    /// SolineId
    /// </summary>
    [SugarColumn(ColumnDescription = "SolineId", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolineId { get; set; }

    /// <summary>
    /// SolineNo
    /// </summary>
    [SugarColumn(ColumnDescription = "SolineNo", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolineNo { get; set; }

    /// <summary>
    /// SolineStatus
    /// </summary>
    [SugarColumn(ColumnDescription = "SolineStatus", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolineStatus { get; set; }

    /// <summary>
    /// 订单产品编码
    /// </summary>
    [SugarColumn(ColumnDescription = "订单产品编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolinePartNo { get; set; }

    /// <summary>
    /// 订单产品描述
    /// </summary>
    [SugarColumn(ColumnDescription = "订单产品描述", Length = 100)]
    [MaxLength(100)]
    public virtual string? SolinePartDesc { get; set; }

    /// <summary>
    /// PegLinePartNo
    /// </summary>
    [SugarColumn(ColumnDescription = "PegLinePartNo", Length = 100)]
    [MaxLength(100)]
    public virtual string? PegLinePartNo { get; set; }

    /// <summary>
    /// PegLinePartDesc
    /// </summary>
    [SugarColumn(ColumnDescription = "PegLinePartDesc", Length = 100)]
    [MaxLength(100)]
    public virtual string? PegLinePartDesc { get; set; }

    /// <summary>
    /// PeggingLinePartStatus
    /// </summary>
    [SugarColumn(ColumnDescription = "PeggingLinePartStatus", Length = 100)]
    [MaxLength(100)]
    public virtual string? PeggingLinePartStatus { get; set; }

    /// <summary>
    /// DemId
    /// </summary>
    [SugarColumn(ColumnDescription = "DemId", Length = 100)]
    [MaxLength(100)]
    public virtual string? DemId { get; set; }

    /// <summary>
    /// DemSourceWithDemType
    /// </summary>
    [SugarColumn(ColumnDescription = "DemSourceWithDemType", Length = 100)]
    [MaxLength(100)]
    public virtual string? DemSourceWithDemType { get; set; }

    /// <summary>
    /// DemSource
    /// </summary>
    [SugarColumn(ColumnDescription = "DemSource", Length = 100)]
    [MaxLength(100)]
    public virtual string? DemSource { get; set; }

    /// <summary>
    /// SupType默认值3
    /// </summary>
    [SugarColumn(ColumnDescription = "SupType默认值3")]
    public virtual int? SupType { get; set; }

    /// <summary>
    /// 工单编码
    /// </summary>
    [SugarColumn(ColumnDescription = "工单编码", Length = 100)]
    [MaxLength(100)]
    public virtual string? SupOrderNo { get; set; }

    /// <summary>
    /// 工单id
    /// </summary>
    [SugarColumn(ColumnDescription = "工单id", Length = 100)]
    [MaxLength(100)]
    public virtual string? SupOrderId { get; set; }

    /// <summary>
    /// 工序提前期
    /// </summary>
    [SugarColumn(ColumnDescription = "工序提前期")]
    public virtual int? ProcessLeadTime { get; set; }

    /// <summary>
    /// 订单承诺交货期
    /// </summary>
    [SugarColumn(ColumnDescription = "订单承诺交货期")]
    public virtual DateTime? SupPopromiseDate { get; set; }

    /// <summary>
    /// 地址位置编码
    /// </summary>
    [SugarColumn(ColumnDescription = "地址位置")]
    public virtual int? Location { get; set; }

    /// <summary>
    /// 默认决策
    /// </summary>
    [SugarColumn(ColumnDescription = "默认决策", Length = 18,DecimalDigits =6)]
    public virtual decimal? DefaultMbdecision { get; set; }

    /// <summary>
    /// 释放DispositionIdForPlo
    /// </summary>
    [SugarColumn(ColumnDescription = "释放DispositionIdForPlo")]
    public virtual int? DispositionIdForPlo { get; set; }

    /// <summary>
    /// Guid
    /// </summary>
    [SugarColumn(ColumnDescription = "PolineId")]
    public virtual int? PolineId { get; set; }

    /// <summary>
    /// PolineShipmentId
    /// </summary>
    [SugarColumn(ColumnDescription = "PolineShipmentId")]
    public virtual int? PolineShipmentId { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public virtual string? OrgId { get; set; }

    /// <summary>
    /// 开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "开始时间")]
    public virtual DateTime? PlanStartTime { get; set; }

    /// <summary>
    /// 结束时间
    /// </summary>
    [SugarColumn(ColumnDescription = "结束时间")]
    public virtual DateTime? PlanStopTime { get; set; }

    /// <summary>
    /// 集成用户
    /// </summary>
    [SugarColumn(ColumnDescription = "集成用户", Length = 100)]
    [MaxLength(100)]
    public virtual string? IntegUserId { get; set; }

    /// <summary>
    /// 集成时间
    /// </summary>
    [SugarColumn(ColumnDescription = "集成时间")]
    public virtual DateTime? IntegTime { get; set; }

    /// <summary>
    /// 工单描述
    /// </summary>
    [SugarColumn(ColumnDescription = "工单描述", Length = 100)]
    [MaxLength(100)]
    public virtual string? SupOrderDesc { get; set; }

    /// <summary>
    /// 购买日期
    /// </summary>
    [SugarColumn(ColumnDescription = "购买日期")]
    public virtual DateTime? PurchaseDate { get; set; }

    /// <summary>
    /// 采购日期
    /// </summary>
    [SugarColumn(ColumnDescription = "采购日期")]
    public virtual DateTime? NeedByDate { get; set; }

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
    /// 发货日期
    /// </summary>
    [SugarColumn(ColumnDescription = "发货日期")]
    public virtual DateTime? MrpshipDate { get; set; }

    /// <summary>
    /// 最早可开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "最早可开始时间")]
    public virtual DateTime? EstimatedShipDate { get; set; }

    /// <summary>
    /// NovestimatedShipDate
    /// </summary>
    [SugarColumn(ColumnDescription = "NovestimatedShipDate")]
    public virtual DateTime? NovestimatedShipDate { get; set; }

    /// <summary>
    /// 在手库存
    /// </summary>
    [SugarColumn(ColumnDescription = "在手库存")]
    public virtual int? QtyOnHand { get; set; }

    /// <summary>
    /// Atpqty
    /// </summary>
    [SugarColumn(ColumnDescription = "Atpqty")]
    public virtual int? Atpqty { get; set; }

    /// <summary>
    /// 是否是预测单
    /// </summary>
    [SugarColumn(ColumnDescription = "是否是预测单")]
    public virtual bool? IsForcast { get; set; }

    /// <summary>
    /// 子库存位置
    /// </summary>
    [SugarColumn(ColumnDescription = "子库存位置", Length = 100)]
    [MaxLength(100)]
    public virtual string? Subinventorylocation { get; set; }

    /// <summary>
    /// 新看板编号
    /// </summary>
    [SugarColumn(ColumnDescription = "新看板编号", Length = 100)]
    [MaxLength(100)]
    public virtual string? NewKanbanNo { get; set; }
}
