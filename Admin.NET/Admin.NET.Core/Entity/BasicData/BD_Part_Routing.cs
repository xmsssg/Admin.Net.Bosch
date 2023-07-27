using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

namespace Admin.NET.Core;

/// <summary>
/// 产品工序版本
/// </summary>
[SugarTable(null, "产品工序版本表")]
[SystemTable]
public class BD_Part_Routing : EntityBase
{
    /// <summary>
    /// 产品工序版本Id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品工序版本Id", Length = 100)]
    [MaxLength(100)]
    public string PartRoutingID { get; set; }

    /// <summary>
    /// 产品工序版本号
    /// </summary>
    [SugarColumn(ColumnDescription = "产品工序版本号", Length = 100)]
    [MaxLength(100)]
    public string PartRoutingNo { get; set; }

    /// <summary>
    /// 产品工序版本名称
    /// </summary>
    [SugarColumn(ColumnDescription = "产品工序版本名称", Length = 100)]
    [MaxLength(100)]
    public string PartRoutingName { get; set; }

    /// <summary>
    /// 组织编码
    /// </summary>
    [SugarColumn(ColumnDescription = "组织编码", Length = 100)]
    [MaxLength(100)]
    public string OrgId { get; set; }

    /// <summary>
    /// 产品编码
    /// </summary>
    [SugarColumn(ColumnDescription = "产品编码", Length = 100)]
    [MaxLength(100)]
    public string PartId { get; set; }

    /// <summary>
    /// 是否标准
    /// </summary>
    [SugarColumn(ColumnDescription = "是否标准")]
    public int IsStandard { get; set; }
}
