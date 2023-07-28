using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 库存信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_StockService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_Stock> _rep;
    public BD_StockService(SqlSugarRepository<BD_Stock> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询库存信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_StockOutput>> Page(BD_StockInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.PartNo), u => u.PartNo.Contains(input.PartNo.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.Batch), u => u.Batch.Contains(input.Batch.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.Location), u => u.Location.Contains(input.Location.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.Bin), u => u.Bin.Contains(input.Bin.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.Serial), u => u.Serial.Contains(input.Serial.Trim()))
                    .WhereIF(input.IsRawMaterial>0, u => u.IsRawMaterial == input.IsRawMaterial)
                    .WhereIF(input.LotSize>0, u => u.LotSize == input.LotSize)

                    .Select<BD_StockOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加库存信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_StockInput input)
    {
        var entity = input.Adapt<BD_Stock>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除库存信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_StockInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新库存信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_StockInput input)
    {
        var entity = input.Adapt<BD_Stock>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取库存信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_Stock> Get([FromQuery] QueryByIdBD_StockInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取库存信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_StockOutput>> List([FromQuery] BD_StockInput input)
    {
        return await _rep.AsQueryable().Select<BD_StockOutput>().ToListAsync();
    }





}

