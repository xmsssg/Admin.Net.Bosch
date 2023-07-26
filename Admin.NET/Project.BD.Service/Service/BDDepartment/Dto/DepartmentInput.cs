// MIT License
//
// Copyright (c) 2021-present zuohuaijun, Daming Co.,Ltd and Contributors
//
// 电话/微信：18020030720 QQ群1：87333204 QQ群2：252381476

using Admin.NET.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BD.Service;
public class DepartmentInput
{
    /// <summary>
    /// 状态
    /// </summary>
    public StatusEnum Status { get; set; }
}


public class PageDepInput : BasePageInput
{
    /// <summary>
    /// 部门编号
    /// </summary>
    public string DepNo { get; set; }

    /// <summary>
    /// 部门类型
    /// </summary>
    public string Remarks { get; set; }
}

public class AddDeptInput : BD_Department
{
    /// <summary>
    /// 部门
    /// </summary>
    [Required(ErrorMessage = "部门编码不能为空")]
    public override string DepNo { get; set; }

    /// <summary>
    /// 部门类型
    /// </summary>
    [Required(ErrorMessage = "部门类型不能为空")]
    public override string Remarks { get; set; }

}
public class UpdateDeptInput : AddDeptInput
{
}
public class DeleteDeptInput : BaseIdInput
{
}