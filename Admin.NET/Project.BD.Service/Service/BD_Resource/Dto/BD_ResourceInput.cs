using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 资源设备信息基础输入参数
    /// </summary>
    public class BD_ResourceBaseInput
    {
        /// <summary>
        /// 资源Id，唯一标识
        /// </summary>
        public virtual string ResID { get; set; }
        
        /// <summary>
        /// 部门Id，关联部门表
        /// </summary>
        public virtual string DepID { get; set; }
        
        /// <summary>
        /// 资源设备名称
        /// </summary>
        public virtual string ResName { get; set; }
        
        /// <summary>
        /// 设备描述
        /// </summary>
        public virtual string ResDesc { get; set; }
        
        /// <summary>
        /// 已弃用Status
        /// </summary>
        public virtual int Status { get; set; }
        
        /// <summary>
        /// 设备类型
        /// </summary>
        public virtual int Type { get; set; }
        
        /// <summary>
        /// 设备产能类型
        /// </summary>
        public virtual int ResType { get; set; }
        
        /// <summary>
        /// 资源设备名称
        /// </summary>
        public virtual bool IsDefault { get; set; }
        
        /// <summary>
        /// 工作中心编号
        /// </summary>
        public virtual string WorkCenterNo { get; set; }
        
        /// <summary>
        /// 设备数量
        /// </summary>
        public virtual int Units { get; set; }
        
        /// <summary>
        /// 已弃用Programmable
        /// </summary>
        public virtual int Programmable { get; set; }
        
        /// <summary>
        /// 已弃用IsSeparable
        /// </summary>
        public virtual int IsSeparable { get; set; }
        
        /// <summary>
        /// 设备是否可用
        /// </summary>
        public virtual int IsAvailable { get; set; }
        
        /// <summary>
        /// 是否是热处理设备
        /// </summary>
        public virtual int IsHeattreat { get; set; }
        
        /// <summary>
        /// Overtime已弃用
        /// </summary>
        public virtual decimal Overtime { get; set; }
        
        /// <summary>
        /// 组织编码
        /// </summary>
        public virtual string OrgID { get; set; }
        
        /// <summary>
        /// 加工时间
        /// </summary>
        public virtual decimal ProcessTime { get; set; }
        
        /// <summary>
        /// 准备时间1
        /// </summary>
        public virtual decimal Setuptime1 { get; set; }
        
        /// <summary>
        /// 准备时间2
        /// </summary>
        public virtual decimal Setuptime2 { get; set; }
        
        /// <summary>
        /// 准备时间3
        /// </summary>
        public virtual decimal Setuptime3 { get; set; }
        
        /// <summary>
        /// 共用编码
        /// </summary>
        public virtual string VersionSign { get; set; }
        
        /// <summary>
        /// isOld已弃用
        /// </summary>
        public virtual int isOld { get; set; }
        
        /// <summary>
        /// 资源设备编码
        /// </summary>
        public virtual string ResNo { get; set; }
        
    }

    /// <summary>
    /// 资源设备信息分页查询输入参数
    /// </summary>
    public class BD_ResourceInput : BasePageInput
    {
        /// <summary>
        /// 资源设备名称
        /// </summary>
        public string ResName { get; set; }
        
        /// <summary>
        /// 设备描述
        /// </summary>
        public string ResDesc { get; set; }
        
        /// <summary>
        /// 设备类型
        /// </summary>
        public int Type { get; set; }
        
        /// <summary>
        /// 设备产能类型
        /// </summary>
        public int ResType { get; set; }
        
        /// <summary>
        /// 工作中心编号
        /// </summary>
        public string WorkCenterNo { get; set; }
        
        /// <summary>
        /// 设备数量
        /// </summary>
        public int Units { get; set; }
        
        /// <summary>
        /// 设备是否可用
        /// </summary>
        public int IsAvailable { get; set; }
        
        /// <summary>
        /// 资源设备编码
        /// </summary>
        public string ResNo { get; set; }
        
    }

    /// <summary>
    /// 资源设备信息增加输入参数
    /// </summary>
    public class AddBD_ResourceInput : BD_ResourceBaseInput
    {
    }

    /// <summary>
    /// 资源设备信息删除输入参数
    /// </summary>
    public class DeleteBD_ResourceInput : BaseIdInput
    {
    }

    /// <summary>
    /// 资源设备信息更新输入参数
    /// </summary>
    public class UpdateBD_ResourceInput : BD_ResourceBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 资源设备信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_ResourceInput : DeleteBD_ResourceInput
    {

    }
