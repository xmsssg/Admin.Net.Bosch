using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FJob
{
    public string Guid { get; set; } = null!;

    public string? JobNo { get; set; }

    public string? OrgId { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public int? DemandQty { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? EarliestStartDate { get; set; }

    public decimal? Priority { get; set; }

    public int? JobType { get; set; }

    public string? JobName { get; set; }

    public DateTime? ContractDate { get; set; }

    public string? Sono { get; set; }

    public string? SolineNo { get; set; }
}
