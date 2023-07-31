using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfWorkOrderOpForPlan
{
    public string WhatIfWoopId { get; set; } = null!;

    public string? WhatIfWorkOrderId { get; set; }

    public string? WorkOrderId { get; set; }

    public string? WoopId { get; set; }

    public string? OpNo { get; set; }

    public string? PreviousOpNo { get; set; }

    public string? NextOpNo { get; set; }

    public int? ModifiedType { get; set; }

    public DateTime? AddTime { get; set; }

    public string? WhatIfScheduleId { get; set; }

    public string? OrgId { get; set; }

    public bool? Completed { get; set; }

    public string? OpName { get; set; }

    public string? OpDesc { get; set; }

    public int? DemandQty { get; set; }

    public DateTime? RequiredDate { get; set; }

    public bool? SetupLock { get; set; }

    public int? LeftQty { get; set; }

    public string? Offset { get; set; }

    public string? Ifv { get; set; }

    public int? ProducedQty { get; set; }

    public int? BatchMachs { get; set; }

    public decimal? TransferTime { get; set; }

    public decimal? Priority { get; set; }
}
