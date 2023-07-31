using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMachine
{
    public string Id { get; set; } = null!;

    public string GroupNo { get; set; } = null!;

    public string? GroupDesc { get; set; }

    public string ResId { get; set; } = null!;

    public string? OrgId { get; set; }

    public int? Maetype { get; set; }

    public int? MachineType { get; set; }
}
