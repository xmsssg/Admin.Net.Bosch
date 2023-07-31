using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FReportDept
{
    public string ReportDeptId { get; set; } = null!;

    public string? ReportId { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? OrgId { get; set; }

    public string? DepId { get; set; }
}
