using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FUserSolver
{
    public string Id { get; set; } = null!;

    public string? UserId { get; set; }

    public string? SolverId { get; set; }

    public bool? Enable { get; set; }
}
