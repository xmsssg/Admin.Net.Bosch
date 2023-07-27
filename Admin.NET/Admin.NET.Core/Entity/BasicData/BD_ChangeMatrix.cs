namespace Admin.NET.Core;

/// <summary>
/// 换型矩阵表
/// </summary>
[SugarTable(null, "换型矩阵表")]
[SystemTable]
public class BD_ChangeMatrix:EntityBase
{

    /// <summary>
    /// 是否清粉
    /// </summary>
    [SugarColumn(ColumnDescription = "是否清粉")]
    public int IsChange { get; set; }

    /// <summary>
    /// 清粉时间
    /// </summary>
    [SugarColumn(ColumnDescription = "清粉时间", Length = 18,DecimalDigits =6)]
    public decimal? ClearPowder { get; set; }

    /// <summary>
    /// 不清粉时间
    /// </summary>
    [SugarColumn(ColumnDescription = "不清粉时间", Length = 18, DecimalDigits = 6)]
    public decimal? NoClearPowder { get; set; }

    /// <summary>
    /// OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "OrgId", Length = 100)]
    [MaxLength(100)]
    public string? OrgId { get; set; }
}
