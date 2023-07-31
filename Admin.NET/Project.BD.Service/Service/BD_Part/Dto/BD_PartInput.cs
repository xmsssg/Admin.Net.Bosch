using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 产品信息基础输入参数
    /// </summary>
    public class BD_PartBaseInput
    {
        /// <summary>
        /// 产品Id
        /// </summary>
        public virtual string PartID { get; set; }
        
        /// <summary>
        /// 组织Id
        /// </summary>
        public virtual string OrgID { get; set; }
        
        /// <summary>
        /// 产品编号
        /// </summary>
        public virtual string PartNo { get; set; }
        
        /// <summary>
        /// 产品名称
        /// </summary>
        public virtual string PartName { get; set; }
        
        /// <summary>
        /// 产品描述
        /// </summary>
        public virtual string PartDesc { get; set; }
        
        /// <summary>
        /// 产品类型
        /// </summary>
        public virtual int PartType { get; set; }
        
        /// <summary>
        /// 产品类型2
        /// </summary>
        public virtual int ProductType { get; set; }
        
        /// <summary>
        /// 已弃用UnitId
        /// </summary>
        public virtual string UnitId { get; set; }
        
        /// <summary>
        /// 已弃用AttachName
        /// </summary>
        public virtual string AttachName { get; set; }
        
        /// <summary>
        /// 已弃用UrlPath
        /// </summary>
        public virtual string UrlPath { get; set; }
        
        /// <summary>
        /// 已弃用产品图片链接
        /// </summary>
        public virtual string Attachment { get; set; }
        
        /// <summary>
        /// 已弃用DefaultMBDecision
        /// </summary>
        public virtual decimal DefaultMBDecision { get; set; }
        
        /// <summary>
        /// 产品分组
        /// </summary>
        public virtual string MfgGroup { get; set; }
        
        /// <summary>
        /// 已弃用LeadTime
        /// </summary>
        public virtual decimal FullLeadTime { get; set; }
        
        /// <summary>
        /// 计划编码
        /// </summary>
        public virtual string PlannerCode { get; set; }
        
        /// <summary>
        /// 图纸编号
        /// </summary>
        public virtual string DrawingNo { get; set; }
        
        /// <summary>
        /// 供货类型
        /// </summary>
        public virtual decimal SupplyType { get; set; }
        
        /// <summary>
        /// 最小批量
        /// </summary>
        public virtual int LotSize { get; set; }
        
        /// <summary>
        /// 准备时间ST
        /// </summary>
        public virtual decimal SetupTimeST { get; set; }
        
        /// <summary>
        /// 优先级
        /// </summary>
        public virtual int ResPriority { get; set; }
        
        /// <summary>
        /// 产品分组编码
        /// </summary>
        public virtual string GroupNo { get; set; }
        
        /// <summary>
        /// 产品所属分类
        /// </summary>
        public virtual string FamilyNo { get; set; }
        
        /// <summary>
        /// 类别
        /// </summary>
        public virtual string CategoryNo { get; set; }
        
    }

    /// <summary>
    /// 产品信息分页查询输入参数
    /// </summary>
    public class BD_PartInput : BasePageInput
    {
        /// <summary>
        /// 产品编号
        /// </summary>
        public string PartNo { get; set; }
        
        /// <summary>
        /// 产品描述
        /// </summary>
        public string PartDesc { get; set; }
        
    }

    /// <summary>
    /// 产品信息增加输入参数
    /// </summary>
    public class AddBD_PartInput : BD_PartBaseInput
    {
    }

    /// <summary>
    /// 产品信息删除输入参数
    /// </summary>
    public class DeleteBD_PartInput : BaseIdInput
    {
    }

    /// <summary>
    /// 产品信息更新输入参数
    /// </summary>
    public class UpdateBD_PartInput : BD_PartBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 产品信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_PartInput : DeleteBD_PartInput
    {

    }
