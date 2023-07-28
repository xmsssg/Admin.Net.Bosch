namespace Project.BD.Service;

    /// <summary>
    /// 库存信息输出参数
    /// </summary>
    public class BD_StockOutput
    {
       /// <summary>
       /// Id
       /// </summary>
       public long Id { get; set; }
    
       /// <summary>
       /// 库存唯一标识
       /// </summary>
       public string StockId { get; set; }
    
       /// <summary>
       /// 产品Id，管理产品表
       /// </summary>
       public string PartID { get; set; }
    
       /// <summary>
       /// 产品编码
       /// </summary>
       public string PartNo { get; set; }
    
       /// <summary>
       /// 产品描述
       /// </summary>
       public string PartDesc { get; set; }
    
       /// <summary>
       /// 组织ID
       /// </summary>
       public string OrgID { get; set; }
    
       /// <summary>
       /// Batch
       /// </summary>
       public string Batch { get; set; }
    
       /// <summary>
       /// 最大库存
       /// </summary>
       public int MaxStock { get; set; }
    
       /// <summary>
       /// 最小库存
       /// </summary>
       public int MinStock { get; set; }
    
       /// <summary>
       /// 已弃用ProdMode
       /// </summary>
       public string ProdMode { get; set; }
    
       /// <summary>
       /// 可用库存
       /// </summary>
       public decimal AvailableStock { get; set; }
    
       /// <summary>
       /// 当前库存
       /// </summary>
       public decimal CurrentStock { get; set; }
    
       /// <summary>
       /// 已弃用ErrorRate
       /// </summary>
       public decimal ErrorRate { get; set; }
    
       /// <summary>
       /// 已弃用ErrorRate
       /// </summary>
       public int SourceType { get; set; }
    
       /// <summary>
       /// 已弃用ErrorRate
       /// </summary>
       public decimal PromiseDate { get; set; }
    
       /// <summary>
       /// 已弃用SubInventoryCode
       /// </summary>
       public string SubInventoryCode { get; set; }
    
       /// <summary>
       /// 定位
       /// </summary>
       public string Locator { get; set; }
    
       /// <summary>
       /// 位置
       /// </summary>
       public string Location { get; set; }
    
       /// <summary>
       /// 转租(第三方)
       /// </summary>
       public string SubLocation { get; set; }
    
       /// <summary>
       /// 容器Bin
       /// </summary>
       public string Bin { get; set; }
    
       /// <summary>
       /// 批量
       /// </summary>
       public string Lot { get; set; }
    
       /// <summary>
       /// 已弃用Serial
       /// </summary>
       public string Serial { get; set; }
    
       /// <summary>
       /// 已弃用Serial
       /// </summary>
       public decimal ATPQty { get; set; }
    
       /// <summary>
       /// 承诺数量
       /// </summary>
       public decimal CommittedQty { get; set; }
    
       /// <summary>
       /// 是否报废
       /// </summary>
       public bool isBad { get; set; }
    
       /// <summary>
       /// 可分配数量
       /// </summary>
       public decimal AllocatedQTY { get; set; }
    
       /// <summary>
       /// 可使用量
       /// </summary>
       public decimal AvailableQOH { get; set; }
    
       /// <summary>
       /// 安全数量
       /// </summary>
       public decimal SafetyStock { get; set; }
    
       /// <summary>
       /// LeadTime
       /// </summary>
       public int LeadTime { get; set; }
    
       /// <summary>
       /// 缺少量
       /// </summary>
       public int ShortageQty { get; set; }
    
       /// <summary>
       /// 库存量
       /// </summary>
       public int InventoryCalculation { get; set; }
    
       /// <summary>
       /// 是否是原材料
       /// </summary>
       public int IsRawMaterial { get; set; }
    
       /// <summary>
       /// 最小批量
       /// </summary>
       public int LotSize { get; set; }
    
       /// <summary>
       /// 废品量
       /// </summary>
       public decimal Scrap { get; set; }
    
       /// <summary>
       /// 去毛刺
       /// </summary>
       public int Deburring { get; set; }
    
       /// <summary>
       /// 最小工序
       /// </summary>
       public string MinOp { get; set; }
    
       /// <summary>
       /// 粉料特性
       /// </summary>
       public string PowderType { get; set; }
    
       /// <summary>
       /// GP最小批量
       /// </summary>
       public int GPLotSize { get; set; }
    
    }
 

