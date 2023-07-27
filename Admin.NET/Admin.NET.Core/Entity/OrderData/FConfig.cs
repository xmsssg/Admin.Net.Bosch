using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FConfig
{
    public string Id { get; set; } = null!;

    public string? KeyName { get; set; }

    public string? ValueNum { get; set; }
}
