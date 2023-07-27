using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FScheduleExceptionConfig
{
    public bool IsRelease { get; set; }

    public int ProjectNo { get; set; }

    public string ProjectName { get; set; } = null!;

    public string? OrgId { get; set; }
}
