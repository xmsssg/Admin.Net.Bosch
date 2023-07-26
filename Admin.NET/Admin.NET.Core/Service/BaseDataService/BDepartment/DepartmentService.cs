// MIT License
//
// Copyright (c) 2021-present zuohuaijun, Daming Co.,Ltd and Contributors
//
// 电话/微信：18020030720 QQ群1：87333204 QQ群2：252381476

using Admin.NET.Core.Service.BaseDataService.BDepartment.Dto;
using Admin.NET.Core.Service.BaseDataService.BDepartment.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.NET.Core.Service.BaseDataService.BDepartment;
public class DepartmentService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_Department> _bd_Depatment_Rep;

    public DepartmentService(SqlSugarRepository<BD_Department> bd_Depatment_Rep)
    {
        _bd_Depatment_Rep = bd_Depatment_Rep;
    }


    #region 获取部门列表分页
    /// <summary>
    /// 获取部门列表分页
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [DisplayName("获取部门列表分页")]
    public async Task<SqlSugarPagedList<BD_Department>> Page(PageDepInput input)
    {
        List<BD_Department> test = await _bd_Depatment_Rep.AsQueryable()
            .WhereIF(!string.IsNullOrWhiteSpace(input.DepNo), u => u.DepNo.Contains(input.DepNo))
            .WhereIF(!string.IsNullOrWhiteSpace(input.Remarks), u => u.Remarks.Contains(input.Remarks))
            .OrderBy(u => u.DepNo).ToListAsync();
        List<BD_Department> test1 = await _bd_Depatment_Rep.AsQueryable()
            .WhereIF(!string.IsNullOrWhiteSpace(input.DepNo), u => u.DepNo.Contains(input.DepNo))
            .OrderBy(u => u.DepNo).ToListAsync();
        List<BD_Department> test2 = await _bd_Depatment_Rep.AsQueryable()
            .WhereIF(!string.IsNullOrWhiteSpace(input.Remarks), u => u.Remarks.Contains(input.Remarks))
            .OrderBy(u => u.DepNo).ToListAsync();
        List<BD_Department> test3 = await _bd_Depatment_Rep.AsQueryable()
            .OrderBy(u => u.DepNo).ToListAsync();
        List<BD_Department> test4 = await _bd_Depatment_Rep.AsQueryable().ToListAsync();
        SqlSugarPagedList<BD_Department>test5 = await _bd_Depatment_Rep.AsQueryable()
            .ToPagedListAsync(input.Page, input.PageSize);

        return await _bd_Depatment_Rep.AsQueryable()
            .WhereIF(!string.IsNullOrWhiteSpace(input.DepNo), u => u.DepNo.Contains(input.DepNo))
            .WhereIF(!string.IsNullOrWhiteSpace(input.Remarks), u => u.Remarks.Contains(input.Remarks))
            .OrderBy(u => u.DepNo)
            .ToPagedListAsync(input.Page, input.PageSize);
    }

    #endregion

    #region 添加新部门
    /// <summary>
    /// 添加新部门
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [UnitOfWork]
    [ApiDescriptionSettings(Name = "Add"), HttpPost]
    [DisplayName("新增部门")]
    public async Task AddDept(AddDeptInput input)
    {
        var user = input.Adapt<BD_Department>();
        user.DepId = Guid.NewGuid().ToString();
        var newUser = await _bd_Depatment_Rep.AsInsertable(user).ExecuteReturnEntityAsync();
    }
    #endregion

    #region 更新部门信息
    /// <summary>
    /// 更新部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [UnitOfWork]
    [ApiDescriptionSettings(Name = "Update"), HttpPost]
    [DisplayName("更新部门信息")]
    public async Task UpdateUser(UpdateDeptInput input)
    {
        var isExist = await _bd_Depatment_Rep.AsQueryable().Filter(null, true).AnyAsync(u => u.DepId == input.DepId);
        if (isExist) throw Oops.Oh(ErrorCodeEnum.D1003);

        await _bd_Depatment_Rep.AsUpdateable(input.Adapt<BD_Department>()).IgnoreColumns(true)
            .IgnoreColumns(u => new { u.DepNo, u.DepName, u.DepDesc,u.Remarks }).ExecuteCommandAsync();

    }
    #endregion

    #region 查看指定部门基本信息

    /// <summary>
    /// 查看指定部门基本信息
    /// </summary>
    /// <returns></returns>
    [DisplayName("查看指定部门基本信息")]
    [ApiDescriptionSettings(Name = "GetDataById"), HttpPost]
    public async Task<BD_Department> GetBaseInfo(BaseIdInput input)
    {
        return await _bd_Depatment_Rep.GetFirstAsync(u => u.Id == input.Id);
    }

    #endregion

    #region 删除部门信息

    /// <summary>
    /// 删除部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [UnitOfWork]
    [ApiDescriptionSettings(Name = "Delete"), HttpPost]
    [DisplayName("删除部门信息")]
    public async Task DeleteUser(DeleteDeptInput input)
    {
        var user = await _bd_Depatment_Rep.GetFirstAsync(u => u.Id == input.Id);
        if (user == null)
            throw Oops.Oh(ErrorCodeEnum.D1002);

        await _bd_Depatment_Rep.DeleteAsync(user);

    }
    #endregion
}
