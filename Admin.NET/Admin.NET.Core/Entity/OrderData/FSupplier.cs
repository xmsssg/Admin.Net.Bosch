using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSupplier
{
    public string Supplierid { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public string? OrgId { get; set; }
}
