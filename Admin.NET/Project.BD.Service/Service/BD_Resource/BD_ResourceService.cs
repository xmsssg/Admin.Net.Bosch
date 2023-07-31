using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 资源设备信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_ResourceService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_Resource> _rep;
    public BD_ResourceService(SqlSugarRepository<BD_Resource> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询资源设备信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_ResourceOutput>> Page(BD_ResourceInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.ResName), u => u.ResName.Contains(input.ResName.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.ResDesc), u => u.ResDesc.Contains(input.ResDesc.Trim()))
                    .WhereIF(input.Type>0, u => u.Type == input.Type)
                    .WhereIF(input.ResType>0, u => u.ResType == input.ResType)
                    .WhereIF(!string.IsNullOrWhiteSpace(input.WorkCenterNo), u => u.WorkCenterNo.Contains(input.WorkCenterNo.Trim()))
                    .WhereIF(input.Units>0, u => u.Units == input.Units)
                    .WhereIF(input.IsAvailable>0, u => u.IsAvailable == input.IsAvailable)
                    .WhereIF(!string.IsNullOrWhiteSpace(input.ResNo), u => u.ResNo.Contains(input.ResNo.Trim()))

                    .Select<BD_ResourceOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加资源设备信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_ResourceInput input)
    {
        var entity = input.Adapt<BD_Resource>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除资源设备信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_ResourceInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新资源设备信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_ResourceInput input)
    {
        var entity = input.Adapt<BD_Resource>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取资源设备信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_Resource> Get([FromQuery] QueryByIdBD_ResourceInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取资源设备信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_ResourceOutput>> List([FromQuery] BD_ResourceInput input)
    {
        return await _rep.AsQueryable().Select<BD_ResourceOutput>().ToListAsync();
    }





}

