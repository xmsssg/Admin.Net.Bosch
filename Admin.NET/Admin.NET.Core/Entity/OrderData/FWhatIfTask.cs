using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfTask
{
    public string WhatIfTaskId { get; set; } = null!;

    public string WhatIfScheduleId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? WhatIfWorkOrderId { get; set; }

    public string? PartId { get; set; }

    public string? ResId { get; set; }

    public string? LaborId { get; set; }

    public string Opno { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public int? IsFrozen { get; set; }

    public decimal? FrozenQty { get; set; }

    public string? ShopNo { get; set; }

    public decimal? DemandQty { get; set; }

    public string? WhatIfWoopId { get; set; }
}
