namespace Project.BD.Service;

    /// <summary>
    /// 换型矩阵输出参数
    /// </summary>
    public class BD_ChangeMatrixDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// 是否清粉
        /// </summary>
        public int IsChange { get; set; }
        
        /// <summary>
        /// 清粉时间
        /// </summary>
        public decimal ClearPowder { get; set; }
        
        /// <summary>
        /// 不清粉时间
        /// </summary>
        public decimal NoClearPowder { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public string OrgId { get; set; }
        
    }
