using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 人机比1v3基础输入参数
    /// </summary>
    public class BD_MachineThirdBaseInput
    {
        /// <summary>
        /// 分组编码
        /// </summary>
        public virtual string GroupNo { get; set; }
        
        /// <summary>
        /// 分组描述
        /// </summary>
        public virtual string GroupDesc { get; set; }
        
        /// <summary>
        /// 设备编码
        /// </summary>
        public virtual string ResNo { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public virtual string OrgId { get; set; }
        
        /// <summary>
        /// 分组类型
        /// </summary>
        public virtual int MachineType { get; set; }
        
        /// <summary>
        /// 压机属性(单料/双料)
        /// </summary>
        public virtual int Maetype { get; set; }
        
    }

    /// <summary>
    /// 人机比1v3分页查询输入参数
    /// </summary>
    public class BD_MachineThirdInput : BasePageInput
    {
        /// <summary>
        /// 分组编码
        /// </summary>
        public string GroupNo { get; set; }
        
        /// <summary>
        /// 设备编码
        /// </summary>
        public string ResNo { get; set; }
        
        /// <summary>
        /// 压机属性(单料/双料)
        /// </summary>
        public int Maetype { get; set; }
        
    }

    /// <summary>
    /// 人机比1v3增加输入参数
    /// </summary>
    public class AddBD_MachineThirdInput : BD_MachineThirdBaseInput
    {
    }

    /// <summary>
    /// 人机比1v3删除输入参数
    /// </summary>
    public class DeleteBD_MachineThirdInput : BaseIdInput
    {
    }

    /// <summary>
    /// 人机比1v3更新输入参数
    /// </summary>
    public class UpdateBD_MachineThirdInput : BD_MachineThirdBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 人机比1v3主键查询输入参数
    /// </summary>
    public class QueryByIdBD_MachineThirdInput : DeleteBD_MachineThirdInput
    {

    }
