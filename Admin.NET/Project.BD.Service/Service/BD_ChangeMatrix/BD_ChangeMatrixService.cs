using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 换型矩阵服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_ChangeMatrixService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_ChangeMatrix> _rep;
    public BD_ChangeMatrixService(SqlSugarRepository<BD_ChangeMatrix> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询换型矩阵
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_ChangeMatrixOutput>> Page(BD_ChangeMatrixInput input)
    {
        var query= _rep.AsQueryable()

                    .Select<BD_ChangeMatrixOutput>()
;
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加换型矩阵
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_ChangeMatrixInput input)
    {
        var entity = input.Adapt<BD_ChangeMatrix>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除换型矩阵
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_ChangeMatrixInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新换型矩阵
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_ChangeMatrixInput input)
    {
        var entity = input.Adapt<BD_ChangeMatrix>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取换型矩阵
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_ChangeMatrix> Get([FromQuery] QueryByIdBD_ChangeMatrixInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取换型矩阵列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_ChangeMatrixOutput>> List([FromQuery] BD_ChangeMatrixInput input)
    {
        return await _rep.AsQueryable().Select<BD_ChangeMatrixOutput>().ToListAsync();
    }





}

