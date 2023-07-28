using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// BOM信息基础输入参数
    /// </summary>
    public class BD_BOMBaseInput
    {
        /// <summary>
        /// BOMId
        /// </summary>
        public virtual string BomId { get; set; }
        
        /// <summary>
        /// 组织Id
        /// </summary>
        public virtual string OrgId { get; set; }
        
        /// <summary>
        /// 主产品Id
        /// </summary>
        public virtual string MasterPartId { get; set; }
        
        /// <summary>
        /// 主产品Id
        /// </summary>
        public virtual string SubPartId { get; set; }
        
        /// <summary>
        /// 根产成品Id
        /// </summary>
        public virtual string RootPartId { get; set; }
        
        /// <summary>
        /// 比例
        /// </summary>
        public virtual decimal NeedQty { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public virtual int SubProductType { get; set; }
        
        /// <summary>
        /// 层级
        /// </summary>
        public virtual int Level { get; set; }
        
        /// <summary>
        /// 图纸链接
        /// </summary>
        public virtual string BomPath { get; set; }
        
        /// <summary>
        /// 对应工序
        /// </summary>
        public virtual string OpNo { get; set; }
        
        /// <summary>
        /// 上层BOM Id
        /// </summary>
        public virtual string UpperLayerBomid { get; set; }
        
        /// <summary>
        /// PartBomId
        /// </summary>
        public virtual string PartBomId { get; set; }
        
        /// <summary>
        /// 子产品层级
        /// </summary>
        public virtual string Slevel { get; set; }
        
        /// <summary>
        /// 主产品层级
        /// </summary>
        public virtual string Mlevel { get; set; }
        
        /// <summary>
        /// 主产品类型
        /// </summary>
        public virtual int MasterPartType { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public virtual int SubPartType { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public virtual DateTime StartTime { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public virtual DateTime StopTime { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public virtual string AvailableLine { get; set; }
        
    }

    /// <summary>
    /// BOM信息分页查询输入参数
    /// </summary>
    public class BD_BOMInput : BasePageInput
    {
        /// <summary>
        /// 主产品Id
        /// </summary>
        public string MasterPartId { get; set; }
        
        /// <summary>
        /// 主产品Id
        /// </summary>
        public string SubPartId { get; set; }
        
        /// <summary>
        /// 根产成品Id
        /// </summary>
        public string RootPartId { get; set; }
        
        /// <summary>
        /// 比例
        /// </summary>
        public decimal NeedQty { get; set; }
        
        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }
        
    }

    /// <summary>
    /// BOM信息增加输入参数
    /// </summary>
    public class AddBD_BOMInput : BD_BOMBaseInput
    {
    }

    /// <summary>
    /// BOM信息删除输入参数
    /// </summary>
    public class DeleteBD_BOMInput : BaseIdInput
    {
    }

    /// <summary>
    /// BOM信息更新输入参数
    /// </summary>
    public class UpdateBD_BOMInput : BD_BOMBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// BOM信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_BOMInput : DeleteBD_BOMInput
    {

    }
