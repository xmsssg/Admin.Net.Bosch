using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FOutputPeggingChange
{
    public string PeggingChangeId { get; set; } = null!;

    public string? PegId { get; set; }

    public string? PrePegId { get; set; }

    public string? RootPegId { get; set; }

    public int? AllocatedQty { get; set; }

    public int? SupplyType { get; set; }

    public int? MakeOrBuy { get; set; }

    public int? PegLevel { get; set; }

    public string? OrderNo { get; set; }

    public decimal? LeadTime { get; set; }

    public DateTime? PromiseDate { get; set; }

    public string? PartNo { get; set; }

    public int? DemandQty { get; set; }

    public string? PlanId { get; set; }

    public string? OrgId { get; set; }

    public int? ChangeType { get; set; }

    public string? Pid { get; set; }

    public string? SolineId { get; set; }

    public string? OutputLevel { get; set; }

    public string? QmspegId { get; set; }
}
