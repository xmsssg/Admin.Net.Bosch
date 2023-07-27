using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMclinePower
{
    public string Guid { get; set; } = null!;

    public string? LineName { get; set; }

    public int? LinePower { get; set; }
}
