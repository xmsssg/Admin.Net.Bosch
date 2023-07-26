using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 部门信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_DepartmentService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_Department> _rep;
    public BD_DepartmentService(SqlSugarRepository<BD_Department> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_DepartmentOutput>> Page(BD_DepartmentInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.DepId), u => u.DepId.Contains(input.DepId.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.WorkshopId), u => u.WorkshopId.Contains(input.WorkshopId.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.DepNo), u => u.DepNo.Contains(input.DepNo.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.DepName), u => u.DepName.Contains(input.DepName.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.DepDesc), u => u.DepDesc.Contains(input.DepDesc.Trim()))
                    .WhereIF(input.Status>0, u => u.Status == input.Status)
                    .WhereIF(!string.IsNullOrWhiteSpace(input.Remarks), u => u.Remarks.Contains(input.Remarks.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.OrgID), u => u.OrgID.Contains(input.OrgID.Trim()))

                    .Select<BD_DepartmentOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_DepartmentInput input)
    {
        var entity = input.Adapt<BD_Department>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_DepartmentInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_DepartmentInput input)
    {
        var entity = input.Adapt<BD_Department>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取部门信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_Department> Get([FromQuery] QueryByIdBD_DepartmentInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取部门信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_DepartmentOutput>> List([FromQuery] BD_DepartmentInput input)
    {
        return await _rep.AsQueryable().Select<BD_DepartmentOutput>().ToListAsync();
    }





}

