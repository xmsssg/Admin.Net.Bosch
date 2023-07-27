using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FHistoryWorkOrderOp
{
    public string HWoopId { get; set; } = null!;

    public string? HWorkOrderId { get; set; }

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

    public int? OpScrapedQty { get; set; }

    public int? OpRejectedQty { get; set; }

    public int? OpAccumulateScrapedQty { get; set; }

    public string? BelongOrgId { get; set; }

    public bool? EditLock { get; set; }

    public decimal? AppliedHours { get; set; }

    public decimal? StandardHours { get; set; }

    public decimal? Variance { get; set; }

    public DateTime? RealStartTime { get; set; }

    public DateTime? RealStopTime { get; set; }

    public decimal? OpSequence { get; set; }

    public string? OpSortNo { get; set; }

    public decimal? CumVar { get; set; }
}
