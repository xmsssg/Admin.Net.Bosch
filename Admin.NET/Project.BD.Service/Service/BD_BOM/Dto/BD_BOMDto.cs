namespace Project.BD.Service;

    /// <summary>
    /// BOM信息输出参数
    /// </summary>
    public class BD_BOMDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// BOMId
        /// </summary>
        public string BomId { get; set; }
        
        /// <summary>
        /// 组织Id
        /// </summary>
        public string OrgId { get; set; }
        
        /// <summary>
        /// 主产品Id
        /// </summary>
        public string MasterPartId { get; set; }
        
        /// <summary>
        /// 主产品Id
        /// </summary>
        public string SubPartId { get; set; }
        
        /// <summary>
        /// 根产成品Id
        /// </summary>
        public string RootPartId { get; set; }
        
        /// <summary>
        /// 比例
        /// </summary>
        public decimal NeedQty { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public int SubProductType { get; set; }
        
        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }
        
        /// <summary>
        /// 图纸链接
        /// </summary>
        public string BomPath { get; set; }
        
        /// <summary>
        /// 对应工序
        /// </summary>
        public string OpNo { get; set; }
        
        /// <summary>
        /// 上层BOM Id
        /// </summary>
        public string UpperLayerBomid { get; set; }
        
        /// <summary>
        /// PartBomId
        /// </summary>
        public string PartBomId { get; set; }
        
        /// <summary>
        /// 子产品层级
        /// </summary>
        public string Slevel { get; set; }
        
        /// <summary>
        /// 主产品层级
        /// </summary>
        public string Mlevel { get; set; }
        
        /// <summary>
        /// 主产品类型
        /// </summary>
        public int MasterPartType { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public int SubPartType { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public DateTime StartTime { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public DateTime StopTime { get; set; }
        
        /// <summary>
        /// 子产品类型
        /// </summary>
        public string AvailableLine { get; set; }
        
    }
