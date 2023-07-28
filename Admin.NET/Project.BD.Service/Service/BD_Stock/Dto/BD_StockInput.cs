using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 库存信息基础输入参数
    /// </summary>
    public class BD_StockBaseInput
    {
        /// <summary>
        /// 库存唯一标识
        /// </summary>
        public virtual string StockId { get; set; }
        
        /// <summary>
        /// 产品Id，管理产品表
        /// </summary>
        public virtual string PartID { get; set; }
        
        /// <summary>
        /// 产品编码
        /// </summary>
        public virtual string PartNo { get; set; }
        
        /// <summary>
        /// 产品描述
        /// </summary>
        public virtual string PartDesc { get; set; }
        
        /// <summary>
        /// 组织ID
        /// </summary>
        public virtual string OrgID { get; set; }
        
        /// <summary>
        /// Batch
        /// </summary>
        public virtual string Batch { get; set; }
        
        /// <summary>
        /// 最大库存
        /// </summary>
        public virtual int MaxStock { get; set; }
        
        /// <summary>
        /// 最小库存
        /// </summary>
        public virtual int MinStock { get; set; }
        
        /// <summary>
        /// 已弃用ProdMode
        /// </summary>
        public virtual string ProdMode { get; set; }
        
        /// <summary>
        /// 可用库存
        /// </summary>
        public virtual decimal AvailableStock { get; set; }
        
        /// <summary>
        /// 当前库存
        /// </summary>
        public virtual decimal CurrentStock { get; set; }
        
        /// <summary>
        /// 已弃用ErrorRate
        /// </summary>
        public virtual decimal ErrorRate { get; set; }
        
        /// <summary>
        /// 已弃用ErrorRate
        /// </summary>
        public virtual int SourceType { get; set; }
        
        /// <summary>
        /// 已弃用ErrorRate
        /// </summary>
        public virtual decimal PromiseDate { get; set; }
        
        /// <summary>
        /// 已弃用SubInventoryCode
        /// </summary>
        public virtual string SubInventoryCode { get; set; }
        
        /// <summary>
        /// 定位
        /// </summary>
        public virtual string Locator { get; set; }
        
        /// <summary>
        /// 位置
        /// </summary>
        public virtual string Location { get; set; }
        
        /// <summary>
        /// 转租(第三方)
        /// </summary>
        public virtual string SubLocation { get; set; }
        
        /// <summary>
        /// 容器Bin
        /// </summary>
        public virtual string Bin { get; set; }
        
        /// <summary>
        /// 批量
        /// </summary>
        public virtual string Lot { get; set; }
        
        /// <summary>
        /// 已弃用Serial
        /// </summary>
        public virtual string Serial { get; set; }
        
        /// <summary>
        /// 已弃用Serial
        /// </summary>
        public virtual decimal ATPQty { get; set; }
        
        /// <summary>
        /// 承诺数量
        /// </summary>
        public virtual decimal CommittedQty { get; set; }
        
        /// <summary>
        /// 是否报废
        /// </summary>
        public virtual bool isBad { get; set; }
        
        /// <summary>
        /// 可分配数量
        /// </summary>
        public virtual decimal AllocatedQTY { get; set; }
        
        /// <summary>
        /// 可使用量
        /// </summary>
        public virtual decimal AvailableQOH { get; set; }
        
        /// <summary>
        /// 安全数量
        /// </summary>
        public virtual decimal SafetyStock { get; set; }
        
        /// <summary>
        /// LeadTime
        /// </summary>
        public virtual int LeadTime { get; set; }
        
        /// <summary>
        /// 缺少量
        /// </summary>
        public virtual int ShortageQty { get; set; }
        
        /// <summary>
        /// 库存量
        /// </summary>
        public virtual int InventoryCalculation { get; set; }
        
        /// <summary>
        /// 是否是原材料
        /// </summary>
        public virtual int IsRawMaterial { get; set; }
        
        /// <summary>
        /// 最小批量
        /// </summary>
        public virtual int LotSize { get; set; }
        
        /// <summary>
        /// 废品量
        /// </summary>
        public virtual decimal Scrap { get; set; }
        
        /// <summary>
        /// 去毛刺
        /// </summary>
        public virtual int Deburring { get; set; }
        
        /// <summary>
        /// 最小工序
        /// </summary>
        public virtual string MinOp { get; set; }
        
        /// <summary>
        /// 粉料特性
        /// </summary>
        public virtual string PowderType { get; set; }
        
        /// <summary>
        /// GP最小批量
        /// </summary>
        public virtual int GPLotSize { get; set; }
        
    }

    /// <summary>
    /// 库存信息分页查询输入参数
    /// </summary>
    public class BD_StockInput : BasePageInput
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        public string PartNo { get; set; }
        
        /// <summary>
        /// Batch
        /// </summary>
        public string Batch { get; set; }
        
        /// <summary>
        /// 可用库存
        /// </summary>
        public decimal AvailableStock { get; set; }
        
        /// <summary>
        /// 当前库存
        /// </summary>
        public decimal CurrentStock { get; set; }
        
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }
        
        /// <summary>
        /// 容器Bin
        /// </summary>
        public string Bin { get; set; }
        
        /// <summary>
        /// 已弃用Serial
        /// </summary>
        public string Serial { get; set; }
        
        /// <summary>
        /// 已弃用Serial
        /// </summary>
        public decimal ATPQty { get; set; }
        
        /// <summary>
        /// 可使用量
        /// </summary>
        public decimal AvailableQOH { get; set; }
        
        /// <summary>
        /// 是否是原材料
        /// </summary>
        public int IsRawMaterial { get; set; }
        
        /// <summary>
        /// 最小批量
        /// </summary>
        public int LotSize { get; set; }
        
    }

    /// <summary>
    /// 库存信息增加输入参数
    /// </summary>
    public class AddBD_StockInput : BD_StockBaseInput
    {
    }

    /// <summary>
    /// 库存信息删除输入参数
    /// </summary>
    public class DeleteBD_StockInput : BaseIdInput
    {
    }

    /// <summary>
    /// 库存信息更新输入参数
    /// </summary>
    public class UpdateBD_StockInput : BD_StockBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 库存信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_StockInput : DeleteBD_StockInput
    {

    }
