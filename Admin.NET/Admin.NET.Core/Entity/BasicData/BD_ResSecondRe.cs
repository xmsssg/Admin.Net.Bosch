using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BResSecondRe
{
    public string SecondResId { get; set; } = null!;

    public string ResId { get; set; } = null!;

    public string? OpType { get; set; }

    public string Guid { get; set; } = null!;

    public bool IsSelected { get; set; }

    public string? OrgId { get; set; }
}
