using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 调度Routing信息基础输入参数
    /// </summary>
    public class BD_Part_RoutingBaseInput
    {
        /// <summary>
        /// 产品工序版本Id
        /// </summary>
        public virtual string PartRoutingID { get; set; }
        
        /// <summary>
        /// 产品工序版本号
        /// </summary>
        public virtual string PartRoutingNo { get; set; }
        
        /// <summary>
        /// 产品工序版本名称
        /// </summary>
        public virtual string PartRoutingName { get; set; }
        
        /// <summary>
        /// 组织编码
        /// </summary>
        public virtual string OrgId { get; set; }
        
        /// <summary>
        /// 产品编码
        /// </summary>
        public virtual string PartId { get; set; }
        
        /// <summary>
        /// 是否标准
        /// </summary>
        public virtual int IsStandard { get; set; }
        
    }

    /// <summary>
    /// 调度Routing信息分页查询输入参数
    /// </summary>
    public class BD_Part_RoutingInput : BasePageInput
    {
        /// <summary>
        /// 产品工序版本号
        /// </summary>
        public string PartRoutingNo { get; set; }
        
        /// <summary>
        /// 产品工序版本名称
        /// </summary>
        public string PartRoutingName { get; set; }
        
    }

    /// <summary>
    /// 调度Routing信息增加输入参数
    /// </summary>
    public class AddBD_Part_RoutingInput : BD_Part_RoutingBaseInput
    {
    }

    /// <summary>
    /// 调度Routing信息删除输入参数
    /// </summary>
    public class DeleteBD_Part_RoutingInput : BaseIdInput
    {
    }

    /// <summary>
    /// 调度Routing信息更新输入参数
    /// </summary>
    public class UpdateBD_Part_RoutingInput : BD_Part_RoutingBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 调度Routing信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_Part_RoutingInput : DeleteBD_Part_RoutingInput
    {

    }
