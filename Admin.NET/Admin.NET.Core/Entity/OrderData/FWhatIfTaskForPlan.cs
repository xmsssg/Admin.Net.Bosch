using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfTaskForPlan
{
    public string WhatIfTaskId { get; set; } = null!;

    public string? WorkOrderNo { get; set; }

    public string? WhatIfWorkOrderId { get; set; }

    public string? WhatIfScheduleId { get; set; }

    public string? ShopNo { get; set; }

    public string? Opno { get; set; }

    public string? OrgId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public string? PartId { get; set; }

    public string? LaborId { get; set; }

    public string? ResId { get; set; }

    public int? DemandQty { get; set; }

    public string? WhatIfWoopId { get; set; }

    public string? PartNo { get; set; }
}
