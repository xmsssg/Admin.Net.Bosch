using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FRule
{
    public string RuleId { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string? RuleNo { get; set; }

    public string? RuleName { get; set; }
}
