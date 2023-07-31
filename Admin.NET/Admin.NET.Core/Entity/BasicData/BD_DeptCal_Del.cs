using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BDeptCal
{
    public string DepId { get; set; } = null!;

    public string CalId { get; set; } = null!;

    public int? Priority { get; set; }
}
