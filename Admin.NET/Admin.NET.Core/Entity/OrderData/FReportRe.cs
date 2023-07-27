using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FReportRe
{
    public string ReportResId { get; set; } = null!;

    public string? ReportDeptId { get; set; }

    public string? ResNo { get; set; }

    public string? ResName { get; set; }

    public string? OrgId { get; set; }
}
