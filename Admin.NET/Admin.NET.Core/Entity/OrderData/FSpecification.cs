using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSpecification
{
    public string SpecId { get; set; } = null!;

    public string? SpecNo { get; set; }

    public string? SpecName { get; set; }

    public string? SpecDesc { get; set; }

    public string? OrgId { get; set; }
}
