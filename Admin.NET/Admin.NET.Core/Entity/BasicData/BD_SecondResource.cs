using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BSecondResource
{
    public string SecondResId { get; set; } = null!;

    public string? DepId { get; set; }

    public string OrgId { get; set; } = null!;

    public string SecondResNo { get; set; } = null!;

    public string? SecondResName { get; set; }

    public string? SecondResDesc { get; set; }

    public int? Type { get; set; }

    public bool? IsDefault { get; set; }

    public int? SecondResQty { get; set; }
}
