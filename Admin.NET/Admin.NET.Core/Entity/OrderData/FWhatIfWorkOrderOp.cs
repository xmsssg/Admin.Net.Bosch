using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfWorkOrderOp
{
    public string WhatIfWoopId { get; set; } = null!;

    public string? WhatIfWorkOrderId { get; set; }

    public string OpNo { get; set; } = null!;

    public string? OpName { get; set; }

    public string? OpDesc { get; set; }

    public int? LeftQty { get; set; }

    public int? Status { get; set; }

    public decimal? DefectsRate { get; set; }

    public decimal? LotSize { get; set; }

    public int? BatchMachs { get; set; }

    public decimal? TransferTime { get; set; }

    public int? DemandQty { get; set; }

    public int? ProducedQty { get; set; }

    public DateTime? PlanStartTime { get; set; }

    public DateTime? PlanStopTime { get; set; }

    public decimal? TotalWorkingTime { get; set; }

    public string? Ifv { get; set; }

    public string? Offset { get; set; }

    public string? Eoffset { get; set; }

    public bool Completed { get; set; }

    public string? OpFunction { get; set; }

    public string? WoopId { get; set; }

    public decimal? InQueue { get; set; }

    public string? Attribute1 { get; set; }

    public bool? SetupLock { get; set; }

    public DateTime? RequiredDate { get; set; }

    public int? OpAccumulateScrapedQty { get; set; }

    public int? OpRejectedQty { get; set; }

    public DateTime? OsppromiseDate { get; set; }

    public int? OpScrapedQty { get; set; }

    public string? BelongOrgId { get; set; }

    public string? NextOpNo { get; set; }

    public string? PreviousOpNo { get; set; }

    public decimal? OpPriority { get; set; }

    public bool? ProgramCompleted { get; set; }
}
