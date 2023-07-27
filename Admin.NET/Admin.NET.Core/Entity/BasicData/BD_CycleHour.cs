namespace Admin.NET.Core;

/// <summary>
/// 产品周期表
/// </summary>
[SugarTable(null, "产品周期表")]
[SystemTable]
public class BD_CycleHour : EntityBase
{
    /// <summary>
    /// 产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string? ItemId { get; set; }

    /// <summary>
    /// 加工最优时长
    /// </summary>
    [SugarColumn(ColumnDescription = "加工最优时长", Length = 18, DecimalDigits = 6)]
    public virtual decimal? GroupCt { get; set; }

    /// <summary>
    /// 准备时间
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Pt { get; set; }

    /// <summary>
    /// 上料时间
    /// </summary>
    [SugarColumn(ColumnDescription = "上料时间", Length = 18, DecimalDigits = 6)]
    public virtual decimal? St { get; set; }

    /// <summary>
    /// 加工时间
    /// </summary>
    [SugarColumn(ColumnDescription = "加工时间", Length = 18, DecimalDigits = 6)]
    public virtual decimal? Mt { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    [SugarColumn(ColumnDescription = "是否可用")]
    public virtual int? IsAvailable { get; set; }

    /// <summary>
    /// 生效时间
    /// </summary>
    [SugarColumn(ColumnDescription = "生效时间")]
    public virtual DateTime? TakeEffectTime { get; set; }

    /// <summary>
    /// 失效时间
    /// </summary>
    [SugarColumn(ColumnDescription = "失效时间")]
    public virtual DateTime? InvalidTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    [SugarColumn(ColumnDescription = "修改时间")]
    public virtual DateTime? UpdateTime { get; set; }
}
