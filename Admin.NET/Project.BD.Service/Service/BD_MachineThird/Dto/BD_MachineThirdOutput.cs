namespace Project.BD.Service;

    /// <summary>
    /// 人机比1v3输出参数
    /// </summary>
    public class BD_MachineThirdOutput
    {
       /// <summary>
       /// Id
       /// </summary>
       public long Id { get; set; }
    
       /// <summary>
       /// 分组编码
       /// </summary>
       public string GroupNo { get; set; }
    
       /// <summary>
       /// 分组描述
       /// </summary>
       public string GroupDesc { get; set; }
    
       /// <summary>
       /// 设备编码
       /// </summary>
       public string ResNo { get; set; }
    
       /// <summary>
       /// OrgId
       /// </summary>
       public string OrgId { get; set; }
    
       /// <summary>
       /// 分组类型
       /// </summary>
       public int MachineType { get; set; }
    
       /// <summary>
       /// 压机属性(单料/双料)
       /// </summary>
       public int Maetype { get; set; }
    
    }
 

