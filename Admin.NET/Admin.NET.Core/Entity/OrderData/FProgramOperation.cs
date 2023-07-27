using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FProgramOperation
{
    public string ProgramOpId { get; set; } = null!;

    public string? ProgramId { get; set; }

    public string? WoopId { get; set; }

    public string? OrgId { get; set; }
}
