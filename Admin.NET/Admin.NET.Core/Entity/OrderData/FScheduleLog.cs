using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FScheduleLog
{
    public string Id { get; set; } = null!;

    public string? ResNo { get; set; }

    public string? ScheduleId { get; set; }
}
