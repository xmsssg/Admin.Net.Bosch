namespace Admin.NET.Core;

/// <summary>
/// 产品工序明细表(Plan)
/// </summary>
[SugarTable(null, "产品工序明细表(Plan)")]
[SystemTable]
public class BOperationPlan : EntityBase
{
    /// <summary>
    /// 工序Id
    /// </summary>
    [SugarColumn(ColumnDescription = "工序Id", Length = 100)]
    [MaxLength(100)]
    public string OpID { get; set; }

    /// <summary>
    /// 组织Id
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 100)]
    [MaxLength(100)]
    public string OrgID { get; set; }

    /// <summary>
    /// 产品Id
    /// </summary>
    [SugarColumn(ColumnDescription = "产品Id", Length = 100)]
    [MaxLength(100)]
    public string PartID { get; set; }

    /// <summary>
    /// 工序编码
    /// </summary>
    [SugarColumn(ColumnDescription = "工序编码", Length = 100)]
    [MaxLength(100)]
    public string OpNo { get; set; }

    /// <summary>
    /// 工序名称
    /// </summary>
    [SugarColumn(ColumnDescription = "工序名称", Length = 100)]
    [MaxLength(100)]
    public string OpName { get; set; }

    /// <summary>
    /// 工序描述
    /// </summary>
    [SugarColumn(ColumnDescription = "工序描述", Length = 100)]
    [MaxLength(100)]
    public string OpDesc { get; set; }

    /// <summary>
    /// 已弃用Status
    /// </summary>
    [SugarColumn(ColumnDescription = "已弃用Status")]
    public int Status { get; set; }

    /// <summary>
    /// 缺陷率
    /// </summary>
    [SugarColumn(ColumnDescription = "缺陷率", Length = 18, DecimalDigits = 6)]
    public decimal DefectsRate { get; set; }

    /// <summary>
    /// 最小批量
    /// </summary>
    [SugarColumn(ColumnDescription = "最小批量", Length = 18, DecimalDigits = 6)]
    public decimal LotSize { get; set; }

    /// <summary>
    /// 批量
    /// </summary>
    [SugarColumn(ColumnDescription = "批量")]
    public int BatchMachs { get; set; }

    /// <summary>
    /// 转运时间
    /// </summary>
    [SugarColumn(ColumnDescription = "转运时间", Length = 18, DecimalDigits = 6)]
    public decimal TransferTime { get; set; }

    /// <summary>
    /// IFV
    /// </summary>
    [SugarColumn(ColumnDescription = "IFV", Length = 100)]
    [MaxLength(100)]
    public string IFV { get; set; }

    /// <summary>
    /// Offset
    /// </summary>
    [SugarColumn(ColumnDescription = "Offset", Length = 100)]
    [MaxLength(100)]
    public string Offset { get; set; }

    /// <summary>
    /// EOffset
    /// </summary>
    [SugarColumn(ColumnDescription = "EOffset", Length = 100)]
    [MaxLength(100)]
    public string EOffset { get; set; }

    /// <summary>
    /// 关联工序版本表Id
    /// </summary>
    [SugarColumn(ColumnDescription = "关联工序版本表Id", Length = 100)]
    [MaxLength(100)]
    public string PartRoutingID { get; set; }

    /// <summary>
    /// Function
    /// </summary>
    [SugarColumn(ColumnDescription = "Function", Length = 100)]
    [MaxLength(100)]
    public string Function { get; set; }

    /// <summary>
    /// UOM
    /// </summary>
    [SugarColumn(ColumnDescription = "UOM")]
    public int UOM { get; set; }

    /// <summary>
    /// 工单编码
    /// </summary>
    [SugarColumn(ColumnDescription = "工单编码", Length = 100)]
    [MaxLength(100)]
    public string WorkOrderNo { get; set; }

    /// <summary>
    /// 下一工序编码
    /// </summary>
    [SugarColumn(ColumnDescription = "下一工序编码", Length = 100)]
    [MaxLength(100)]
    public string NextOpNo { get; set; }

    /// <summary>
    /// 上一工序编码
    /// </summary>
    [SugarColumn(ColumnDescription = "上一工序编码", Length = 100)]
    [MaxLength(100)]
    public string PreviousOpNo { get; set; }

    /// <summary>
    /// 工序排序字段
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 100)]
    [MaxLength(100)]
    public string OpSortNo { get; set; }

    /// <summary>
    /// 标准工时
    /// </summary>
    [SugarColumn(ColumnDescription = "标准工时", Length = 100)]
    [MaxLength(100)]
    public string StandardHours { get; set; }

    /// <summary>
    /// 反馈节点工序编码
    /// </summary>
    [SugarColumn(ColumnDescription = "反馈节点工序", Length = 100)]
    [MaxLength(100)]
    public string FeedbackNodeNO { get; set; }

    /// <summary>
    /// 反馈节点工序名称
    /// </summary>
    [SugarColumn(ColumnDescription = "反馈节点工序名称", Length = 100)]
    [MaxLength(100)]
    public string FeedbackNodeName { get; set; }

    /// <summary>
    /// 混合批次大小
    /// </summary>
    [SugarColumn(ColumnDescription = "混合批次大小", Length = 18, DecimalDigits = 6)]
    public decimal MixBatchSize { get; set; }

    /// <summary>
    /// 加工时间
    /// </summary>
    [SugarColumn(ColumnDescription = "加工时间", Length = 18, DecimalDigits = 6)]
    public decimal ProcessingTime { get; set; }

    /// <summary>
    /// 最小等待时间
    /// </summary>
    [SugarColumn(ColumnDescription = "等待时间", Length = 18, DecimalDigits = 6)]
    public decimal MinQueueTime { get; set; }

    /// <summary>
    /// 最大等待时间
    /// </summary>
    [SugarColumn(ColumnDescription = "组织Id", Length = 18, DecimalDigits = 6)]
    public decimal MaxQueueTime { get; set; }
}
