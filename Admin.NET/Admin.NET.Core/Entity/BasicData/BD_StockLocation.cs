using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

namespace Admin.NET.Core;

/// <summary>
/// 库存位置信息表
/// </summary>
[SugarTable(null, "库存位置信息表")]
[SystemTable]
internal class BD_StockLocation : EntityBase
{
    /// <summary>
    /// 库存信息唯一标识
    /// </summary>
    [SugarColumn(ColumnDescription = "库存信息唯一标识", Length = 100)]
    [MaxLength(100)]
    public string Guid { get; set; }

    /// <summary>
    /// 库存Id，关联库存表
    /// </summary>
    [SugarColumn(ColumnDescription = "库存Id，关联库存表", Length = 100)]
    [MaxLength(100)]
    public string StockID { get; set; }

    /// <summary>
    /// 产品编码
    /// </summary>
    [SugarColumn(ColumnDescription = "产品编码", Length = 100)]
    [MaxLength(100)]
    public string PartNo { get; set; }

    /// <summary>
    /// 位置
    /// </summary>
    [SugarColumn(ColumnDescription = "位置", Length = 100)]
    [MaxLength(100)]
    public string Location { get; set; }

    /// <summary>
    /// 批号
    /// </summary>
    [SugarColumn(ColumnDescription = "批号", Length = 100)]
    [MaxLength(100)]
    public string Batch { get; set; }

    /// <summary>
    /// 箱
    /// </summary>
    [SugarColumn(ColumnDescription = "箱", Length = 100)]
    [MaxLength(100)]
    public string Bin { get; set; }

    /// <summary>
    /// Serial
    /// </summary>
    [SugarColumn(ColumnDescription = "Serial", Length = 100)]
    [MaxLength(100)]
    public string Serial { get; set; }

    /// <summary>
    /// 库存量
    /// </summary>
    [SugarColumn(ColumnDescription = "库存量")]
    public decimal StockQty { get; set; }

    /// <summary>
    /// 可用库存
    /// </summary>
    [SugarColumn(ColumnDescription = "可用库存")]
    public decimal AvaliableQOH { get; set; }

    /// <summary>
    /// ATP库存
    /// </summary>
    [SugarColumn(ColumnDescription = "ATP库存")]
    public decimal ATPQty { get; set; }

    /// <summary>
    /// 组织编号
    /// </summary>
    [SugarColumn(ColumnDescription = "组织编号", Length = 100)]
    [MaxLength(100)]
    public string OrgID { get; set; }

    /// <summary>
    /// 特殊库存量
    /// </summary>
    [SugarColumn(ColumnDescription = "特殊库存量", Length = 100)]
    [MaxLength(100)]
    public string SpecialStock { get; set; }

    /// <summary>
    /// 存储类型
    /// </summary>
    [SugarColumn(ColumnDescription = "存储类型", Length = 100)]
    [MaxLength(100)]
    public string StorageType { get; set; }

}
