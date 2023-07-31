using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSolineMrbinfo
{
    public string Guid { get; set; } = null!;

    public string SoLineId { get; set; } = null!;

    public int Mrbinfo { get; set; }

    public string Orgid { get; set; } = null!;

    public DateTime? Mrbecd { get; set; }

    public DateTime? Mrbpriority { get; set; }
}
