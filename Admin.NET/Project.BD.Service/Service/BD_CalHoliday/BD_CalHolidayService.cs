using Admin.NET.Core;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.FriendlyException;
using Mapster;
using Project.BD.Service.Const;

namespace Project.BD.Service;
/// <summary>
/// 假期信息服务
/// </summary>
[ApiDescriptionSettings(ServiceConst.GroupName, Order = 100)]
public class BD_CalHolidayService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<BD_CalHoliday> _rep;
    public BD_CalHolidayService(SqlSugarRepository<BD_CalHoliday> rep)
    {
        _rep = rep;
    }

    /// <summary>
    /// 分页查询假期信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Page")]
    public async Task<SqlSugarPagedList<BD_CalHolidayOutput>> Page(BD_CalHolidayInput input)
    {
        var query= _rep.AsQueryable()
                    .WhereIF(!string.IsNullOrWhiteSpace(input.HolidayName), u => u.HolidayName.Contains(input.HolidayName.Trim()))
                    .WhereIF(!string.IsNullOrWhiteSpace(input.ResourceNo), u => u.ResourceNo.Contains(input.ResourceNo.Trim()))

                    .Select<BD_CalHolidayOutput>()
;
        if(input.StartTimeRange != null && input.StartTimeRange.Count >0)
        {
                DateTime? start= input.StartTimeRange[0]; 
                query = query.WhereIF(start.HasValue, u => u.StartTime > start);
                if (input.StartTimeRange.Count >1 && input.StartTimeRange[1].HasValue)
                {
                    var end = input.StartTimeRange[1].Value.AddDays(1);
                    query = query.Where(u => u.StartTime < end);
                }
        } 
        if(input.StopTimeRange != null && input.StopTimeRange.Count >0)
        {
                DateTime? start= input.StopTimeRange[0]; 
                query = query.WhereIF(start.HasValue, u => u.StopTime > start);
                if (input.StopTimeRange.Count >1 && input.StopTimeRange[1].HasValue)
                {
                    var end = input.StopTimeRange[1].Value.AddDays(1);
                    query = query.Where(u => u.StopTime < end);
                }
        } 
        query = query.OrderBuilder(input);
        return await query.ToPagedListAsync(input.Page, input.PageSize);
    }

    /// <summary>
    /// 增加假期信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Add")]
    public async Task Add(AddBD_CalHolidayInput input)
    {
        var entity = input.Adapt<BD_CalHoliday>();
        await _rep.InsertAsync(entity);
    }

    /// <summary>
    /// 删除假期信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Delete")]
    public async Task Delete(DeleteBD_CalHolidayInput input)
    {
        var entity = await _rep.GetFirstAsync(u => u.Id == input.Id) ?? throw Oops.Oh(ErrorCodeEnum.D1002);
        await _rep.FakeDeleteAsync(entity);   //假删除
    }

    /// <summary>
    /// 更新假期信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [ApiDescriptionSettings(Name = "Update")]
    public async Task Update(UpdateBD_CalHolidayInput input)
    {
        var entity = input.Adapt<BD_CalHoliday>();
        await _rep.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
    }

    /// <summary>
    /// 获取假期信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "Detail")]
    public async Task<BD_CalHoliday> Get([FromQuery] QueryByIdBD_CalHolidayInput input)
    {
        return await _rep.GetFirstAsync(u => u.Id == input.Id);
    }

    /// <summary>
    /// 获取假期信息列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    [ApiDescriptionSettings(Name = "List")]
    public async Task<List<BD_CalHolidayOutput>> List([FromQuery] BD_CalHolidayInput input)
    {
        return await _rep.AsQueryable().Select<BD_CalHolidayOutput>().ToListAsync();
    }





}

