using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSolver
{
    public string Id { get; set; } = null!;

    public string SolverName { get; set; } = null!;

    public string SolverType { get; set; } = null!;

    public string Url { get; set; } = null!;

    public bool? Enable { get; set; }

    public string? MrporderGenerationNew { get; set; }

    public string? SolverSelExec { get; set; }

    public string? OrgId { get; set; }

    public string? SystemType { get; set; }
}
