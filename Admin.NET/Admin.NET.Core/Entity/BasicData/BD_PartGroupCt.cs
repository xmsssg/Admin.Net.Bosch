using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BPartGroupCt
{
    public string Id { get; set; } = null!;

    public string? PartNo { get; set; }

    public int? GroupType { get; set; }

    public decimal? GroupCt { get; set; }

    public string? GroupNo { get; set; }
}
