// MIT License
//
// Copyright (c) 2021-present zuohuaijun, Daming Co.,Ltd and Contributors
//
// 电话/微信：18020030720 QQ群1：87333204 QQ群2：252381476

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.NET.Core;

/// <summary>
/// 部门表
/// </summary>
[SugarTable(null, "系统审计日志表")]
[SystemTable]
public class BD_Department : EntityBase
{
    /// <summary>
    /// 部门Id，唯一标识
    /// </summary>
    [SugarColumn(ColumnDescription = "部门Id，唯一标识", Length = 100)]
    [ MaxLength(100)]
    public virtual string DepId { get; set; }

    /// <summary>
    /// 部门WorkshopId
    /// </summary>
    [SugarColumn(ColumnDescription = "部门WorkshopId", Length = 100)]
    [ MaxLength(100)]
    public virtual string WorkshopId { get; set; }

    /// <summary>
    /// 部门编号
    /// </summary>
    [SugarColumn(ColumnDescription = "部门编号", Length = 100)]
    [Required, MaxLength(100)]
    public virtual string DepNo { get; set; }

    /// <summary>
    /// 部门名称
    /// </summary>
    [SugarColumn(ColumnDescription = "部门名称", Length = 100)]
    [ MaxLength(100)]
    public virtual string DepName { get; set; }

    /// <summary>
    /// 部门描述
    /// </summary>
    [SugarColumn(ColumnDescription = "部门描述", Length = 100)]
    [ MaxLength(100)]
    public virtual string DepDesc { get; set; }

    /// <summary>
    /// 部门状态，默认为1
    /// </summary>
    [SugarColumn(ColumnDescription = "部门状态，默认为1")]
    public virtual int? Status { get; set; }

    /// <summary>
    /// 部门备注，现用于部门类型
    /// </summary>
    [SugarColumn(ColumnDescription = "部门备注，现用于部门类型", Length = 100)]
    [Required, MaxLength(100)]
    public virtual string Remarks { get; set; }

    /// <summary>
    /// 组织OrgId
    /// </summary>
    [SugarColumn(ColumnDescription = "组织OrgId", Length = 100)]
    [ MaxLength(100)]
    public virtual string OrgID { get; set; }
}


