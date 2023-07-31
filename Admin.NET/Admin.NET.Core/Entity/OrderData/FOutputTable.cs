using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FOutputTable
{
    public string Id { get; set; } = null!;

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public bool? IsPeggingPart { get; set; }

    public string? OrgId { get; set; }
}
