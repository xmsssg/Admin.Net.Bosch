using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfWorkOrderOpResForPlan
{
    public string WhatIfWoopResId { get; set; } = null!;

    public string? WoopResId { get; set; }

    public string? WhatIfWorkOrderId { get; set; }

    public string? WhatIfWoopId { get; set; }

    public decimal? ResId { get; set; }

    public decimal? Setuptime { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ProcessTime { get; set; }

    public decimal? Priority { get; set; }

    public bool? NotAllowed { get; set; }

    public decimal? QueueTime { get; set; }

    public int? ModifiedType { get; set; }

    public DateTime? AddTime { get; set; }

    public string? WhatIfScheduleId { get; set; }

    public string? OrgId { get; set; }

    public string? WoopId { get; set; }

    public int? SetupQty { get; set; }

    public bool? Assigned { get; set; }

    public int? Enabled { get; set; }
}
