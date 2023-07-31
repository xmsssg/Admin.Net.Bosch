using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 日历信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_CalendarGeneralService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_CalendarGeneral> _rep;
    public BD_CalendarGeneralService(SqlSugarRepository<BD_CalendarGeneral> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询日历信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_CalendarGeneralOutput>> Page(BD_CalendarGeneralInput input)
    {
        var query= _rep.AsQueryable()

                    .Select<BD_CalendarGeneralOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加日历信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_CalendarGeneralInput input)
    {
        var entity = input.Adapt<BD_CalendarGeneral>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除日历信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_CalendarGeneralInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新日历信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_CalendarGeneralInput input)
    {
        var entity = input.Adapt<BD_CalendarGeneral>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取日历信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_CalendarGeneral> Get([FromQuery] QueryByIdBD_CalendarGeneralInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取日历信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_CalendarGeneralOutput>> List([FromQuery] BD_CalendarGeneralInput input)
    {
        return await _rep.AsQueryable().Select<BD_CalendarGeneralOutput>().ToListAsync();
    }





}

