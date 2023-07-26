using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 部门信息基础输入参数
    /// </summary>
    public class BD_DepartmentBaseInput
    {
        /// <summary>
        /// 部门Id，唯一标识
        /// </summary>
        public virtual string DepId { get; set; }
        
        /// <summary>
        /// 部门WorkshopId
        /// </summary>
        public virtual string WorkshopId { get; set; }
        
        /// <summary>
        /// 部门编号
        /// </summary>
        public virtual string DepNo { get; set; }
        
        /// <summary>
        /// 部门名称
        /// </summary>
        public virtual string DepName { get; set; }
        
        /// <summary>
        /// 部门描述
        /// </summary>
        public virtual string DepDesc { get; set; }
        
        /// <summary>
        /// 部门状态，默认为1
        /// </summary>
        public virtual int Status { get; set; }
        
        /// <summary>
        /// 部门备注，现用于部门类型
        /// </summary>
        public virtual string Remarks { get; set; }
        
        /// <summary>
        /// 组织OrgId
        /// </summary>
        public virtual string OrgID { get; set; }
        
    }

    /// <summary>
    /// 部门信息分页查询输入参数
    /// </summary>
    public class BD_DepartmentInput : BasePageInput
    {
        /// <summary>
        /// 部门Id，唯一标识
        /// </summary>
        public string DepId { get; set; }
        
        /// <summary>
        /// 部门WorkshopId
        /// </summary>
        public string WorkshopId { get; set; }
        
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DepNo { get; set; }
        
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepName { get; set; }
        
        /// <summary>
        /// 部门描述
        /// </summary>
        public string DepDesc { get; set; }
        
        /// <summary>
        /// 部门状态，默认为1
        /// </summary>
        public int Status { get; set; }
        
        /// <summary>
        /// 部门备注，现用于部门类型
        /// </summary>
        public string Remarks { get; set; }
        
        /// <summary>
        /// 组织OrgId
        /// </summary>
        public string OrgID { get; set; }
        
    }

    /// <summary>
    /// 部门信息增加输入参数
    /// </summary>
    public class AddBD_DepartmentInput : BD_DepartmentBaseInput
    {
    }

    /// <summary>
    /// 部门信息删除输入参数
    /// </summary>
    public class DeleteBD_DepartmentInput : BaseIdInput
    {
    }

    /// <summary>
    /// 部门信息更新输入参数
    /// </summary>
    public class UpdateBD_DepartmentInput : BD_DepartmentBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 部门信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_DepartmentInput : DeleteBD_DepartmentInput
    {

    }
