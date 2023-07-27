using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FReport
{
    public string ReportId { get; set; } = null!;

    public string? ReportNo { get; set; }

    public string? ReportName { get; set; }

    public string? OrgId { get; set; }

    public int? ReportType { get; set; }
}
