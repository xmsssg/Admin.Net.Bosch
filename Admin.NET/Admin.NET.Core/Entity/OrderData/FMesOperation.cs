using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FMesOperation
{
    public string MesopId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? MesopNo { get; set; }

    public string? MesopName { get; set; }

    public string? Opno { get; set; }

    public string? OpName { get; set; }
}
