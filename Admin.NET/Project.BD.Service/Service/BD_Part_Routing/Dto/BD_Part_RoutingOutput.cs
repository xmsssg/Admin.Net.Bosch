namespace Project.BD.Service;

    /// <summary>
    /// 调度Routing信息输出参数
    /// </summary>
    public class BD_Part_RoutingOutput
    {
       /// <summary>
       /// Id
       /// </summary>
       public long Id { get; set; }
    
       /// <summary>
       /// 产品工序版本Id
       /// </summary>
       public string PartRoutingID { get; set; }
    
       /// <summary>
       /// 产品工序版本号
       /// </summary>
       public string PartRoutingNo { get; set; }
    
       /// <summary>
       /// 产品工序版本名称
       /// </summary>
       public string PartRoutingName { get; set; }
    
       /// <summary>
       /// 组织编码
       /// </summary>
       public string OrgId { get; set; }
    
       /// <summary>
       /// 产品编码
       /// </summary>
       public string PartId { get; set; }
    
       /// <summary>
       /// 是否标准
       /// </summary>
       public int IsStandard { get; set; }
    
    }
 

