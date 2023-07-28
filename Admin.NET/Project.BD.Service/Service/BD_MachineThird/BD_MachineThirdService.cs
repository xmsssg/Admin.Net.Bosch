using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 人机比1v3服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_MachineThirdService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_MachineThird> _rep;
    public BD_MachineThirdService(SqlSugarRepository<BD_MachineThird> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询人机比1v3
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_MachineThirdOutput>> Page(BD_MachineThirdInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.GroupNo), u => u.GroupNo.Contains(input.GroupNo.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.ResNo), u => u.ResNo.Contains(input.ResNo.Trim()))
                    .WhereIF(input.Maetype>0, u => u.Maetype == input.Maetype)

                    .Select<BD_MachineThirdOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加人机比1v3
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_MachineThirdInput input)
    {
        var entity = input.Adapt<BD_MachineThird>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除人机比1v3
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_MachineThirdInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新人机比1v3
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_MachineThirdInput input)
    {
        var entity = input.Adapt<BD_MachineThird>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取人机比1v3
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_MachineThird> Get([FromQuery] QueryByIdBD_MachineThirdInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取人机比1v3列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_MachineThirdOutput>> List([FromQuery] BD_MachineThirdInput input)
    {
        return await _rep.AsQueryable().Select<BD_MachineThirdOutput>().ToListAsync();
    }





}

