using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 调度Routing信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_Part_RoutingService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_Part_Routing> _rep;
    public BD_Part_RoutingService(SqlSugarRepository<BD_Part_Routing> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询调度Routing信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_Part_RoutingOutput>> Page(BD_Part_RoutingInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.PartRoutingNo), u => u.PartRoutingNo.Contains(input.PartRoutingNo.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.PartRoutingName), u => u.PartRoutingName.Contains(input.PartRoutingName.Trim()))

                    .Select<BD_Part_RoutingOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加调度Routing信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_Part_RoutingInput input)
    {
        var entity = input.Adapt<BD_Part_Routing>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除调度Routing信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_Part_RoutingInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新调度Routing信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_Part_RoutingInput input)
    {
        var entity = input.Adapt<BD_Part_Routing>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取调度Routing信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_Part_Routing> Get([FromQuery] QueryByIdBD_Part_RoutingInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取调度Routing信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_Part_RoutingOutput>> List([FromQuery] BD_Part_RoutingInput input)
    {
        return await _rep.AsQueryable().Select<BD_Part_RoutingOutput>().ToListAsync();
    }





}

