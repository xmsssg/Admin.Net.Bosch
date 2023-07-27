using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FOutputCriticalPath
{
    public string PlanCritiPathId { get; set; } = null!;

    public string? Pid { get; set; }

    public string? PlanId { get; set; }

    public string? OrgId { get; set; }

    public string? PegId { get; set; }
}
