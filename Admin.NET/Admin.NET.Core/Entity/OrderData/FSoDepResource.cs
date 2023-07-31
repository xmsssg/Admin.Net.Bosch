using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoDepResource
{
    public string RecordId { get; set; } = null!;

    public string? Guid { get; set; }

    public string? OrganizationId { get; set; }

    public string? DepartmentNo { get; set; }

    public string? DepartmentNoId { get; set; }

    public string? DepartmentName { get; set; }

    public string? WorkCenterNo { get; set; }

    public string? WorkCenterNoId { get; set; }

    public decimal? Units { get; set; }

    public int? WorkCenterType { get; set; }

    public int? OracleResType { get; set; }

    public string? WorkCenterDesc { get; set; }
}
