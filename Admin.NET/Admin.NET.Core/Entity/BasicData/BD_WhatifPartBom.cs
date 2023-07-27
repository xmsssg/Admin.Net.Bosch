using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWhatifPartBom
{
    public string PartBomId { get; set; } = null!;

    public string? PartBomNo { get; set; }

    public string? PartBomName { get; set; }

    public string OrgId { get; set; } = null!;

    public string? PartId { get; set; }

    public int? IsStandard { get; set; }
}
