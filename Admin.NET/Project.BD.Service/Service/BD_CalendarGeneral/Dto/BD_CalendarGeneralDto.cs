namespace Project.BD.Service;

    /// <summary>
    /// 日历信息输出参数
    /// </summary>
    public class BD_CalendarGeneralDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Guid
        /// </summary>
        public string Guid { get; set; }
        
        /// <summary>
        /// ResId(弃用)
        /// </summary>
        public string ResId { get; set; }
        
        /// <summary>
        /// ResNo(弃用)
        /// </summary>
        public string ResNo { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public string OrgId { get; set; }
        
        /// <summary>
        /// 日历编码
        /// </summary>
        public string CalNo { get; set; }
        
        /// <summary>
        /// 日历名称
        /// </summary>
        public string CalName { get; set; }
        
        /// <summary>
        /// 可用开始时间
        /// </summary>
        public DateTime BeginDate { get; set; }
        
        /// <summary>
        /// 可用结束时间
        /// </summary>
        public DateTime EndDate { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 工作日
        /// </summary>
        public string WorkDay { get; set; }
        
        /// <summary>
        /// 班次1
        /// </summary>
        public string Shift1 { get; set; }
        
        /// <summary>
        /// 班次2
        /// </summary>
        public string Shift2 { get; set; }
        
        /// <summary>
        /// 班次3
        /// </summary>
        public string Shift3 { get; set; }
        
        /// <summary>
        /// 日历类型
        /// </summary>
        public int Type { get; set; }
        
        /// <summary>
        /// 优先级
        /// </summary>
        public decimal Priority { get; set; }
        
        /// <summary>
        /// 是否默认
        /// </summary>
        public int IsDefault { get; set; }
        
        /// <summary>
        /// 工作中心编码
        /// </summary>
        public string WorkCenterNo { get; set; }
        
        /// <summary>
        /// 管理日历信息表Id
        /// </summary>
        public string CalId { get; set; }
        
    }
