using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// BOM信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_BOMService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_BOM> _rep;
    public BD_BOMService(SqlSugarRepository<BD_BOM> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询BOM信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_BOMOutput>> Page(BD_BOMInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.MasterPartId), u => u.MasterPartId.Contains(input.MasterPartId.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.SubPartId), u => u.SubPartId.Contains(input.SubPartId.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.RootPartId), u => u.RootPartId.Contains(input.RootPartId.Trim()))
                    .WhereIF(input.Level>0, u => u.Level == input.Level)

                    .Select<BD_BOMOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加BOM信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_BOMInput input)
    {
        var entity = input.Adapt<BD_BOM>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除BOM信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_BOMInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新BOM信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_BOMInput input)
    {
        var entity = input.Adapt<BD_BOM>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取BOM信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_BOM> Get([FromQuery] QueryByIdBD_BOMInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取BOM信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_BOMOutput>> List([FromQuery] BD_BOMInput input)
    {
        return await _rep.AsQueryable().Select<BD_BOMOutput>().ToListAsync();
    }





}

