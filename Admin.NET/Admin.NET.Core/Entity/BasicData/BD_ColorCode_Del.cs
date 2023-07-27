using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BD_ColorCode_Del
{
    public string ColorId { get; set; } = null!;

    public string? ColorNo { get; set; }

    public string? ColorName { get; set; }

    public string? ColorDesc { get; set; }
}
