using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BProgram
{
    public string Id { get; set; } = null!;

    public string PartId { get; set; } = null!;

    public string? PowderNo { get; set; }

    public string? ProgramNo { get; set; }

    public string? OrgId { get; set; }

    public string? Priority { get; set; }

    public string? AvailableLine { get; set; }
}
