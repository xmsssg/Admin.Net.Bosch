namespace Project.BD.Service;

    /// <summary>
    /// 假期信息输出参数
    /// </summary>
    public class BD_CalHolidayDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// HolidayId
        /// </summary>
        public string HolidayId { get; set; }
        
        /// <summary>
        /// 假期名称
        /// </summary>
        public string HolidayName { get; set; }
        
        /// <summary>
        /// 假期描述
        /// </summary>
        public string HolidayDesc { get; set; }
        
        /// <summary>
        /// 假期开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        
        /// <summary>
        /// 假期结束时间
        /// </summary>
        public DateTime StopTime { get; set; }
        
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddedTime { get; set; }
        
        /// <summary>
        /// 假期停运设备编码
        /// </summary>
        public string ResourceNo { get; set; }
        
        /// <summary>
        /// 假期停运设备名称
        /// </summary>
        public string ResourceName { get; set; }
        
        /// <summary>
        /// 假期类型
        /// </summary>
        public int Type { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public string OrgId { get; set; }
        
        /// <summary>
        /// 日历信息表Id(弃用)
        /// </summary>
        public string CalId { get; set; }
        
        /// <summary>
        /// 休息总时长
        /// </summary>
        public decimal DownTime { get; set; }
        
    }
