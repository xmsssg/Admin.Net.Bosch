using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfWorkOrderForPlan
{
    public string WhatIfWorkOrderId { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WhatIfScheduleId { get; set; }

    public string? OrgId { get; set; }

    public DateTime? EarliestStartTime { get; set; }

    public DateTime? Duedate { get; set; }

    public decimal? Priority { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedType { get; set; }

    public DateTime? AddTime { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? DemandQty { get; set; }

    public int? Status { get; set; }

    public string? WorkOrderDesc { get; set; }

    public int? OracleJobStatus { get; set; }

    public int Firm { get; set; }

    public string? PlannerCode { get; set; }
}
