namespace Project.BD.Service;

    /// <summary>
    /// 部门信息输出参数
    /// </summary>
    public class BD_DepartmentDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// 部门Id，唯一标识
        /// </summary>
        public string DepId { get; set; }
        
        /// <summary>
        /// 部门WorkshopId
        /// </summary>
        public string WorkshopId { get; set; }
        
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DepNo { get; set; }
        
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepName { get; set; }
        
        /// <summary>
        /// 部门描述
        /// </summary>
        public string DepDesc { get; set; }
        
        /// <summary>
        /// 部门状态，默认为1
        /// </summary>
        public int Status { get; set; }
        
        /// <summary>
        /// 部门备注，现用于部门类型
        /// </summary>
        public string Remarks { get; set; }
        
        /// <summary>
        /// 组织OrgId
        /// </summary>
        public string OrgID { get; set; }
        
    }
