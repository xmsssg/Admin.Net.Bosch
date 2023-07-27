namespace Admin.NET.Core;

/// <summary>
/// 库存信息表
/// </summary>
[SugarTable(null, "库存信息表")]
[SystemTable]
public class BD_Stock : EntityBase
{
    /// <summary>
    /// 库存唯一标识
    /// </summary>
    [SugarColumn(ColumnDescription = "库存唯一标识", Length = 100)]
    [MaxLength(100)]
    public string StockId { get; set; }

    /// <summary>
    /// 产品Id，管理产品表
    /// </summary>
    [SugarColumn(ColumnDescription = "产品Id，管理产品表", Length = 100)]
    [MaxLength(100)]
    public string PartID { get; set; }

    /// <summary>
    /// 产品编码
    /// </summary>
    [SugarColumn(ColumnDescription = "产品编码", Length = 100)]
    [MaxLength(100)]
    public string PartNo { get; set; }

    /// <summary>
    /// 产品描述
    /// </summary>
    [SugarColumn(ColumnDescription = "产品描述", Length = 100)]
    [MaxLength(100)]
    public string PartDesc { get; set; }

    /// <summary>
    /// 组织ID
    /// </summary>
    [SugarColumn(ColumnDescription = "组织ID", Length = 100)]
    [MaxLength(100)]
    public string OrgID  { get; set; }

    /// <summary>
    /// Batch
    /// </summary>
    [SugarColumn(ColumnDescription = "Batch", Length = 100)]
    [MaxLength(100)]
    public string Batch { get; set; }

    /// <summary>
    /// 最大库存
    /// </summary>
    [SugarColumn(ColumnDescription = "最大库存")]
    public int MaxStock { get; set; }

    /// <summary>
    /// 最小库存
    /// </summary>
    [SugarColumn(ColumnDescription = "最小库存")]
    public int MinStock { get; set; }

    /// <summary>
    /// 已弃用ProdMode
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用ProdMode", Length = 100)]
    [MaxLength(100)]
    public string ProdMode { get; set; }

    /// <summary>
    /// 可用库存
    /// </summary>
    [SugarColumn(ColumnDescription = "可用库存", Length = 18, DecimalDigits = 6)]
    public decimal AvailableStock { get; set; }

    /// <summary>
    /// 当前库存
    /// </summary>
    [SugarColumn(ColumnDescription = "当前库存", Length = 18, DecimalDigits = 6)]
    public decimal CurrentStock { get; set; }

    /// <summary>
    /// 已弃用ErrorRate
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用ErrorRate", Length = 18, DecimalDigits = 6)]
    public decimal ErrorRate { get; set; }

    /// <summary>
    /// 已弃用ErrorRate
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用ErrorRate")]
    public int SourceType { get; set; }

    /// <summary>
    /// 已弃用ErrorRate
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用ErrorRate", Length = 18, DecimalDigits = 6)]
    public decimal PromiseDate { get; set; }

    /// <summary>
    /// 已弃用SubInventoryCode
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用SubInventoryCode", Length = 100)]
    [MaxLength(100)]
    public string SubInventoryCode { get; set; }

    /// <summary>
    /// 定位
    /// </summary>
    [SugarColumn(ColumnDescription = "定位", Length = 100)]
    [MaxLength(100)]
    public string Locator { get; set; }

    /// <summary>
    /// 位置
    /// </summary>
    [SugarColumn(ColumnDescription = "位置", Length = 100)]
    [MaxLength(100)]
    public string Location { get; set; }

    /// <summary>
    /// 转租(第三方)
    /// </summary>
    [SugarColumn(ColumnDescription = "转租(第三方)", Length = 100)]
    [MaxLength(100)]
    public string SubLocation { get; set; }

    /// <summary>
    /// 容器Bin
    /// </summary>
    [SugarColumn(ColumnDescription = "容器Bin", Length = 100)]
    [MaxLength(100)]
    public string Bin { get; set; }

    /// <summary>
    /// 批量
    /// </summary>
    [SugarColumn(ColumnDescription = "批量", Length = 100)]
    [MaxLength(100)]
    public string Lot { get; set; }

    /// <summary>
    /// 已弃用Serial
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用Serial", Length = 100)]
    [MaxLength(100)]
    public string Serial { get; set; }

    /// <summary>
    /// 已弃用Serial
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用Serial", Length = 18, DecimalDigits = 6)]
    public decimal ATPQty { get; set; }

    /// <summary>
    /// 承诺数量
    /// </summary>
    [SugarColumn(ColumnDescription = "承诺数量", Length = 18, DecimalDigits = 6)]
    public decimal CommittedQty { get; set; }

    /// <summary>
    /// 是否报废
    /// </summary>
    [SugarColumn(ColumnDescription = "是否报废")]
    public bool isBad { get; set; }

    /// <summary>
    /// 可分配数量
    /// </summary>
    [SugarColumn(ColumnDescription = "可分配数量", Length = 18, DecimalDigits = 6)]
    public decimal AllocatedQTY { get; set; }

    /// <summary>
    /// 可使用量
    /// </summary>
    [SugarColumn(ColumnDescription = "可使用量", Length = 18, DecimalDigits = 6)]
    public decimal AvailableQOH { get; set; }

    /// <summary>
    /// 安全数量
    /// </summary>
    [SugarColumn(ColumnDescription = "安全数量", Length = 18, DecimalDigits = 6)]
    public decimal SafetyStock { get; set; }

    /// <summary>
    /// LeadTime
    /// </summary>
    [SugarColumn(ColumnDescription = "LeadTime")]
    public int LeadTime { get; set; }

    /// <summary>
    /// 缺少量
    /// </summary>
    [SugarColumn(ColumnDescription = "缺少量")]
    public int ShortageQty { get; set; }

    /// <summary>
    /// 库存量
    /// </summary>
    [SugarColumn(ColumnDescription = "库存量")]
    public int InventoryCalculation { get; set; }

    /// <summary>
    /// 是否是原材料
    /// </summary>
    [SugarColumn(ColumnDescription = "是否是原材料")]
    public int IsRawMaterial { get; set; }

    /// <summary>
    /// 最小批量
    /// </summary>
    [SugarColumn(ColumnDescription = "最小批量")]
    public int LotSize { get; set; }

    /// <summary>
    /// 废品量
    /// </summary>
    [SugarColumn(ColumnDescription = "废品量", Length = 18, DecimalDigits = 6)]
    public decimal Scrap { get; set; }

    /// <summary>
    /// 去毛刺
    /// </summary>
    [SugarColumn(ColumnDescription = "去毛刺")]
    public int Deburring { get; set; }

    /// <summary>
    /// 最小工序
    /// </summary>
    [SugarColumn(ColumnDescription = "最小工序", Length = 100)]
    [MaxLength(100)]
    public string MinOp { get; set; }

    /// <summary>
    /// 粉料特性
    /// </summary>
    [SugarColumn(ColumnDescription = "粉料特性", Length = 100)]
    [MaxLength(100)]
    public string PowderType { get; set; }

    /// <summary>
    /// GP最小批量
    /// </summary>
    [SugarColumn(ColumnDescription = "GP最小批量", Length = 100)]
    public int GPLotSize { get; set; }
}
