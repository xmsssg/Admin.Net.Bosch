namespace Admin.NET.Core;

/// <summary>
/// 产品信息表
/// </summary>
[SugarTable(null, "产品信息表")]
[SystemTable]
public class BD_Part : EntityBase
{
    /// <summary>
    /// 产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品Id", Length = 100)]
    [MaxLength(100)]
    public virtual string PartID { get; set; }

    /// <summary>
    /// 组织Id
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 100)]
    [MaxLength(100)]
    public virtual string OrgID { get; set; }

    /// <summary>
    /// 产品编号
    /// </summary>
    [SugarColumn(ColumnDescription = "产品编号", Length = 100)]
    [MaxLength(100)]
    public virtual string PartNo { get; set; }

    /// <summary>
    /// 产品名称
    /// </summary>
    [SugarColumn(ColumnDescription = "产品名称", Length = 100)]
    [MaxLength(100)]
    public virtual string PartName { get; set; }

    /// <summary>
    /// 产品描述
    /// </summary>
    [SugarColumn(ColumnDescription = "产品描述", Length = 100)]
    [MaxLength(100)]
    public virtual string PartDesc { get; set; }

    /// <summary>
    /// 产品类型
    /// </summary>
    [SugarColumn(ColumnDescription = "产品类型")]
    public virtual int PartType { get; set; }

    /// <summary>
    /// 产品类型2
    /// </summary>
    [SugarColumn(ColumnDescription = "产品类型2")]
    public virtual int ProductType { get; set; }

    /// <summary>
    /// 已弃用UnitId
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用UnitId", Length = 100)]
    [MaxLength(100)]
    public virtual string UnitId { get; set; }

    /// <summary>
    /// 已弃用AttachName
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用AttachName", Length = 100)]
    [MaxLength(100)]
    public virtual string AttachName { get; set; }

    /// <summary>
    /// 已弃用UrlPath
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用UrlPath", Length = 100)]
    [MaxLength(100)]
    public virtual string UrlPath { get; set; }

    /// <summary>
    /// 已弃用产品图片链接
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用产品图片链接", Length = 100)]
    [MaxLength(100)]
    public virtual string Attachment { get; set; } //image

    /// <summary>
    /// 已弃用DefaultMBDecision
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用DefaultMBDecision",Length =18,DecimalDigits =6)]
    public virtual decimal DefaultMBDecision { get; set; }

    /// <summary>
    /// 产品分组
    /// </summary>
    [SugarColumn(ColumnDescription = "产品分组", Length = 100)]
    [MaxLength(100)]
    public virtual string MfgGroup { get; set; }

    /// <summary>
    /// 已弃用LeadTime
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用LeadTime", Length = 18, DecimalDigits = 6)]
    public virtual decimal FullLeadTime { get; set; }

    /// <summary>
    /// 计划编码
    /// </summary>
    [SugarColumn(ColumnDescription = "计划编码", Length = 100)]
    [MaxLength(100)]
    public virtual string PlannerCode { get; set; }

    /// <summary>
    /// 图纸编号
    /// </summary>
    [SugarColumn(ColumnDescription = "图纸编号", Length = 100)]
    [MaxLength(100)]
    public virtual string DrawingNo { get; set; }

    /// <summary>
    /// 供货类型
    /// </summary>
    [SugarColumn(ColumnDescription = "供货类型", Length = 18, DecimalDigits = 6)]
    public virtual decimal SupplyType { get; set; }

    /// <summary>
    /// 最小批量
    /// </summary>
    [SugarColumn(ColumnDescription = "最小批量")]
    public virtual int LotSize { get; set; }

    /// <summary>
    /// 准备时间ST
    /// </summary>
    [SugarColumn(ColumnDescription = "准备时间ST", Length = 18, DecimalDigits = 6)]
    public virtual decimal SetupTimeST { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    [SugarColumn(ColumnDescription = "优先级")]
    public virtual int ResPriority { get; set; }

    /// <summary>
    /// 产品分组编码
    /// </summary>
    [SugarColumn(ColumnDescription = "产品分组编码", Length = 100)]
    [MaxLength(100)]
    public virtual string GroupNo { get; set; }

    /// <summary>
    /// 产品所属分类
    /// </summary>
    [SugarColumn(ColumnDescription = "产品所属分类", Length = 100)]
    [MaxLength(100)]
    public virtual string FamilyNo { get; set; }

    /// <summary>
    /// 类别
    /// </summary>
    [SugarColumn(ColumnDescription = "类别", Length = 100)]
    [MaxLength(100)]
    public virtual string CategoryNo { get; set; }
}
