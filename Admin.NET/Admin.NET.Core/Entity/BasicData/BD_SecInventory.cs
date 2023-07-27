using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BSecInventory
{
    public string? OrgId { get; set; }

    public string? SecInventoryName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public bool? IsBad { get; set; }

    public string Id { get; set; } = null!;
}
