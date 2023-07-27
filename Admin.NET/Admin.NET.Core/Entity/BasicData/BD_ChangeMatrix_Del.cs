using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BD_ChangeMatrix_Del
{
    public string Id { get; set; } = null!;

    public int IsChange { get; set; }

    public decimal? ClearPowder { get; set; }

    public decimal? NoClearPowder { get; set; }

    public string? OrgId { get; set; }
}
