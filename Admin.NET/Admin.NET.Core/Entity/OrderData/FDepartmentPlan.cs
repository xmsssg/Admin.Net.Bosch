using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FDepartmentPlan
{
    public string PlanId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? ItemId { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDesc { get; set; }

    public string? DeptId { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? DeptOpNo { get; set; }

    public string? DeptOpDesc { get; set; }

    public string? DeptNextOpNo { get; set; }

    public decimal? DeptCapacityPerHour { get; set; }
}
