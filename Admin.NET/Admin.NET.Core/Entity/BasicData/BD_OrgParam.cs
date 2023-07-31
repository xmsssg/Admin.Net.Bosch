using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BOrgParam
{
    public string ParamId { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string ProductTitle { get; set; } = null!;

    public string? Producer { get; set; }

    public string? OrgType { get; set; }

    public string? Logo { get; set; }

    public string? Welcome { get; set; }

    public string? ReleaseDate { get; set; }

    public string? LicenseKey { get; set; }

    public string? AppNodeNum { get; set; }

    public string? SolverNodeNum { get; set; }

    public string? OrgDetail { get; set; }
}
