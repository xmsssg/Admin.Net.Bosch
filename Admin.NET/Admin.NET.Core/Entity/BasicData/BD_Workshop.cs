using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWorkshop
{
    public string WorkshopId { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string WorkshopNo { get; set; } = null!;

    public string? WorkshopName { get; set; }

    public string? WorkshopDesc { get; set; }

    public int? Status { get; set; }
}
