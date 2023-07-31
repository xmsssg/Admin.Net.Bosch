namespace Admin.NET.Core;

/// <summary>
/// 系统字典类型表种子数据
/// </summary>
public class SysDictTypeSeedData : ISqlSugarEntitySeedData<SysDictType>
{
    /// <summary>
    /// 种子数据
    /// </summary>
    /// <returns></returns>
    [IgnoreUpdate]
    public IEnumerable<SysDictType> HasData()
    {
        return new[]
        {
            new SysDictType{ Id=1300000000101, Name="代码生成控件类型", Code="code_gen_effect_type", OrderNo=100, Remark="代码生成控件类型", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000102, Name="代码生成查询类型", Code="code_gen_query_type", OrderNo=100, Remark="代码生成查询类型", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000103, Name="代码生成.NET类型", Code="code_gen_net_type", OrderNo=100, Remark="代码生成.NET类型", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000104, Name="代码生成方式", Code="code_gen_create_type", OrderNo=100, Remark="代码生成方式", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000105, Name="代码生成基类", Code="code_gen_base_class", OrderNo=100, Remark="代码生成基类", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000106, Name="资源设备类型", Code="resource_Type_class", OrderNo=100, Remark="资源设备类型", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000107, Name="资源设备产能类型", Code="resource_CapacityType_class", OrderNo=100, Remark="资源设备产能类型", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000108, Name="部门类型", Code="department_class", OrderNo=100, Remark="部门类型", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000000109, Name="资源设备是否可用", Code="resource_IsAvailable_class", OrderNo=100, Remark="资源设备是否可用", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000011000, Name="产品是否去毛刺", Code="Part_IsDeburring_class", OrderNo=100, Remark="产品是否去毛刺", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000012000, Name="产品是否有小工序", Code="Part_IsMinOp_class", OrderNo=100, Remark="产品是否有小工序", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
            new SysDictType{ Id=1300000013000, Name="产品粉料特性", Code="Part_PowderType_class", OrderNo=100, Remark="产品粉料特性", Status=StatusEnum.Enable, CreateTime=DateTime.Parse("2022-02-10 00:00:00") },
        };
    }
}