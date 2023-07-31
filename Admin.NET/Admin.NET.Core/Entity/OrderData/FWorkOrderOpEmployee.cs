using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpEmployee
{
    public string WoopId { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public decimal? Hours { get; set; }

    public string? OrgId { get; set; }
}
