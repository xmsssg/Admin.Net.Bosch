using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 产品信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_PartService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_Part> _rep;
    public BD_PartService(SqlSugarRepository<BD_Part> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询产品信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_PartOutput>> Page(BD_PartInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.PartNo), u => u.PartNo.Contains(input.PartNo.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.PartDesc), u => u.PartDesc.Contains(input.PartDesc.Trim()))

                    .Select<BD_PartOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加产品信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_PartInput input)
    {
        var entity = input.Adapt<BD_Part>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除产品信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_PartInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新产品信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_PartInput input)
    {
        var entity = input.Adapt<BD_Part>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取产品信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_Part> Get([FromQuery] QueryByIdBD_PartInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取产品信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_PartOutput>> List([FromQuery] BD_PartInput input)
    {
        return await _rep.AsQueryable().Select<BD_PartOutput>().ToListAsync();
    }





}

