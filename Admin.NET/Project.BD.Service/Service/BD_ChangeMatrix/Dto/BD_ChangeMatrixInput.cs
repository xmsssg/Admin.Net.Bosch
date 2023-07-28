using Admin.NET.Core;
using System.ComponentModel.DataAnnotations;

namespace Project.BD.Service;

    /// <summary>
    /// 换型矩阵基础输入参数
    /// </summary>
    public class BD_ChangeMatrixBaseInput
    {
        /// <summary>
        /// 是否清粉
        /// </summary>
        public virtual int IsChange { get; set; }
        
        /// <summary>
        /// 清粉时间
        /// </summary>
        public virtual decimal ClearPowder { get; set; }
        
        /// <summary>
        /// 不清粉时间
        /// </summary>
        public virtual decimal NoClearPowder { get; set; }
        
        /// <summary>
        /// OrgId
        /// </summary>
        public virtual string OrgId { get; set; }
        
    }

    /// <summary>
    /// 换型矩阵分页查询输入参数
    /// </summary>
    public class BD_ChangeMatrixInput : BasePageInput
    {
    }

    /// <summary>
    /// 换型矩阵增加输入参数
    /// </summary>
    public class AddBD_ChangeMatrixInput : BD_ChangeMatrixBaseInput
    {
    }

    /// <summary>
    /// 换型矩阵删除输入参数
    /// </summary>
    public class DeleteBD_ChangeMatrixInput : BaseIdInput
    {
    }

    /// <summary>
    /// 换型矩阵更新输入参数
    /// </summary>
    public class UpdateBD_ChangeMatrixInput : BD_ChangeMatrixBaseInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }
        
    }

    /// <summary>
    /// 换型矩阵主键查询输入参数
    /// </summary>
    public class QueryByIdBD_ChangeMatrixInput : DeleteBD_ChangeMatrixInput
    {

    }
