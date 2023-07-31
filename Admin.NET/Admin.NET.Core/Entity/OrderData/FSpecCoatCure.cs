using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSpecCoatCure
{
    public string Ccid { get; set; } = null!;

    public string? SpecId { get; set; }

    public string? Ccno { get; set; }

    public string? Ccname { get; set; }

    public decimal? Cctime { get; set; }

    public int? Sequence { get; set; }

    public int? Cctype { get; set; }

    public string? OrgId { get; set; }
}
