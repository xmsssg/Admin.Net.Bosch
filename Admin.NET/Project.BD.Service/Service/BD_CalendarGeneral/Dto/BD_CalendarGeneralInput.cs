using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 日历信息基础输入参数
    /// </summary>
    public class BD_CalendarGeneralBaseInput
    {
        /// <summary>
        /// Guid
        /// </summary>
        public virtual string Guid { get; set; }
        
        /// <summary>
        /// ResId(弃用)
        /// </summary>
        public virtual string ResId { get; set; }
        
        /// <summary>
        /// ResNo(弃用)
        /// </summary>
        public virtual string ResNo { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public virtual string OrgId { get; set; }
        
        /// <summary>
        /// 日历编码
        /// </summary>
        public virtual string CalNo { get; set; }
        
        /// <summary>
        /// 日历名称
        /// </summary>
        public virtual string CalName { get; set; }
        
        /// <summary>
        /// 可用开始时间
        /// </summary>
        public virtual DateTime BeginDate { get; set; }
        
        /// <summary>
        /// 可用结束时间
        /// </summary>
        public virtual DateTime EndDate { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get; set; }
        
        /// <summary>
        /// 工作日
        /// </summary>
        public virtual string WorkDay { get; set; }
        
        /// <summary>
        /// 班次1
        /// </summary>
        public virtual string Shift1 { get; set; }
        
        /// <summary>
        /// 班次2
        /// </summary>
        public virtual string Shift2 { get; set; }
        
        /// <summary>
        /// 班次3
        /// </summary>
        public virtual string Shift3 { get; set; }
        
        /// <summary>
        /// 日历类型
        /// </summary>
        public virtual int Type { get; set; }
        
        /// <summary>
        /// 优先级
        /// </summary>
        public virtual decimal Priority { get; set; }
        
        /// <summary>
        /// 是否默认
        /// </summary>
        public virtual int IsDefault { get; set; }
        
        /// <summary>
        /// 工作中心编码
        /// </summary>
        public virtual string WorkCenterNo { get; set; }
        
        /// <summary>
        /// 管理日历信息表Id
        /// </summary>
        public virtual string CalId { get; set; }
        
    }

    /// <summary>
    /// 日历信息分页查询输入参数
    /// </summary>
    public class BD_CalendarGeneralInput : BasePageInput
    {
    }

    /// <summary>
    /// 日历信息增加输入参数
    /// </summary>
    public class AddBD_CalendarGeneralInput : BD_CalendarGeneralBaseInput
    {
    }

    /// <summary>
    /// 日历信息删除输入参数
    /// </summary>
    public class DeleteBD_CalendarGeneralInput : BaseIdInput
    {
    }

    /// <summary>
    /// 日历信息更新输入参数
    /// </summary>
    public class UpdateBD_CalendarGeneralInput : BD_CalendarGeneralBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 日历信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_CalendarGeneralInput : DeleteBD_CalendarGeneralInput
    {

    }
