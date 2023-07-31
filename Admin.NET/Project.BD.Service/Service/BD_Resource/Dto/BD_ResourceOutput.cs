namespace Project.BD.Service;

    /// <summary>
    /// 资源设备信息输出参数
    /// </summary>
    public class BD_ResourceOutput
    {
       /// <summary>
       /// Id
       /// </summary>
       public long Id { get; set; }
    
       /// <summary>
       /// 资源Id，唯一标识
       /// </summary>
       public string ResID { get; set; }
    
       /// <summary>
       /// 部门Id，关联部门表
       /// </summary>
       public string DepID { get; set; }
    
       /// <summary>
       /// 资源设备名称
       /// </summary>
       public string ResName { get; set; }
    
       /// <summary>
       /// 设备描述
       /// </summary>
       public string ResDesc { get; set; }
    
       /// <summary>
       /// 已弃用Status
       /// </summary>
       public int Status { get; set; }
    
       /// <summary>
       /// 设备类型
       /// </summary>
       public int Type { get; set; }
    
       /// <summary>
       /// 设备产能类型
       /// </summary>
       public int ResType { get; set; }
    
       /// <summary>
       /// 资源设备名称
       /// </summary>
       public bool IsDefault { get; set; }
    
       /// <summary>
       /// 工作中心编号
       /// </summary>
       public string WorkCenterNo { get; set; }
    
       /// <summary>
       /// 设备数量
       /// </summary>
       public int Units { get; set; }
    
       /// <summary>
       /// 已弃用Programmable
       /// </summary>
       public int Programmable { get; set; }
    
       /// <summary>
       /// 已弃用IsSeparable
       /// </summary>
       public int IsSeparable { get; set; }
    
       /// <summary>
       /// 设备是否可用
       /// </summary>
       public int IsAvailable { get; set; }
    
       /// <summary>
       /// 是否是热处理设备
       /// </summary>
       public int IsHeattreat { get; set; }
    
       /// <summary>
       /// Overtime已弃用
       /// </summary>
       public decimal Overtime { get; set; }
    
       /// <summary>
       /// 组织编码
       /// </summary>
       public string OrgID { get; set; }
    
       /// <summary>
       /// 加工时间
       /// </summary>
       public decimal ProcessTime { get; set; }
    
       /// <summary>
       /// 准备时间1
       /// </summary>
       public decimal Setuptime1 { get; set; }
    
       /// <summary>
       /// 准备时间2
       /// </summary>
       public decimal Setuptime2 { get; set; }
    
       /// <summary>
       /// 准备时间3
       /// </summary>
       public decimal Setuptime3 { get; set; }
    
       /// <summary>
       /// 共用编码
       /// </summary>
       public string VersionSign { get; set; }
    
       /// <summary>
       /// isOld已弃用
       /// </summary>
       public int isOld { get; set; }
    
       /// <summary>
       /// 资源设备编码
       /// </summary>
       public string ResNo { get; set; }
    
    }
 

