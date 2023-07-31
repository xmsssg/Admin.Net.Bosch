using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BResourceUnit
{
    public string ResId { get; set; } = null!;

    public string? ResNo { get; set; }

    public string? GroupNo { get; set; }

    public int? IsDefault { get; set; }

    public string? OrgId { get; set; }
}
