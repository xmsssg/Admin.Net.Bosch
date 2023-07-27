using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BD_CalRule_Del
{
    public string CalId { get; set; } = null!;

    public string RuleId { get; set; } = null!;

    public int? Priority { get; set; }

    public string? WeekDay { get; set; }

    public int? Cycle { get; set; }
}
