using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FPloresGroup
{
    public string ResGroupId { get; set; } = null!;

    public string? DepId { get; set; }

    public string OrgId { get; set; } = null!;

    public string ResNo { get; set; } = null!;

    public string? ResName { get; set; }

    public string? ResDesc { get; set; }

    public int? Status { get; set; }

    public int? Type { get; set; }

    public int? ResType { get; set; }

    public bool? IsDefault { get; set; }
}
