using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BD_CalDetail_Del
{
    public string CalDetailId { get; set; } = null!;

    public string CalId { get; set; } = null!;

    public DateTime? Day { get; set; }

    public bool? WorkDay { get; set; }

    public string? OrgId { get; set; }
}
