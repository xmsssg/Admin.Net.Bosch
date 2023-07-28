using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 假期信息基础输入参数
    /// </summary>
    public class BD_CalHolidayBaseInput
    {
        /// <summary>
        /// HolidayId
        /// </summary>
        public virtual string HolidayId { get; set; }
        
        /// <summary>
        /// 假期名称
        /// </summary>
        public virtual string HolidayName { get; set; }
        
        /// <summary>
        /// 假期描述
        /// </summary>
        public virtual string HolidayDesc { get; set; }
        
        /// <summary>
        /// 假期开始时间
        /// </summary>
        public virtual DateTime StartTime { get; set; }
        
        /// <summary>
        /// 假期结束时间
        /// </summary>
        public virtual DateTime StopTime { get; set; }
        
        /// <summary>
        /// 添加时间
        /// </summary>
        public virtual DateTime AddedTime { get; set; }
        
        /// <summary>
        /// 假期停运设备编码
        /// </summary>
        public virtual string ResourceNo { get; set; }
        
        /// <summary>
        /// 假期停运设备名称
        /// </summary>
        public virtual string ResourceName { get; set; }
        
        /// <summary>
        /// 假期类型
        /// </summary>
        public virtual int Type { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public virtual string OrgId { get; set; }
        
        /// <summary>
        /// 日历信息表Id(弃用)
        /// </summary>
        public virtual string CalId { get; set; }
        
        /// <summary>
        /// 休息总时长
        /// </summary>
        public virtual decimal DownTime { get; set; }
        
    }

    /// <summary>
    /// 假期信息分页查询输入参数
    /// </summary>
    public class BD_CalHolidayInput : BasePageInput
    {
        /// <summary>
        /// 假期名称
        /// </summary>
        public string HolidayName { get; set; }
        
        /// <summary>
        /// 假期开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        
        /// <summary>
         /// 假期开始时间范围
         /// </summary>
         public List<DateTime?> StartTimeRange { get; set; } 
        /// <summary>
        /// 假期结束时间
        /// </summary>
        public DateTime StopTime { get; set; }
        
        /// <summary>
         /// 假期结束时间范围
         /// </summary>
         public List<DateTime?> StopTimeRange { get; set; } 
        /// <summary>
        /// 假期停运设备编码
        /// </summary>
        public string ResourceNo { get; set; }
        
    }

    /// <summary>
    /// 假期信息增加输入参数
    /// </summary>
    public class AddBD_CalHolidayInput : BD_CalHolidayBaseInput
    {
    }

    /// <summary>
    /// 假期信息删除输入参数
    /// </summary>
    public class DeleteBD_CalHolidayInput : BaseIdInput
    {
    }

    /// <summary>
    /// 假期信息更新输入参数
    /// </summary>
    public class UpdateBD_CalHolidayInput : BD_CalHolidayBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 假期信息主键查询输入参数
    /// </summary>
    public class QueryByIdBD_CalHolidayInput : DeleteBD_CalHolidayInput
    {

    }
