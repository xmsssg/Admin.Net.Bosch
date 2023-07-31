using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpForPlan
{
    public string WoopId { get; set; } = null!;

    public string? WorkOrderId { get; set; }

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

    public bool? Completed { get; set; }

    public string? OpFunction { get; set; }

    public decimal? OpScrapedQty { get; set; }

    public decimal? InQueue { get; set; }

    public string? Attribute1 { get; set; }

    public bool? SetupLock { get; set; }

    public DateTime? RequiredDate { get; set; }

    public int? OpAccumulateScrapedQty { get; set; }

    public int? OpRejectedQty { get; set; }

    public DateTime? OsppromiseDate { get; set; }

    public string? BelongOrgId { get; set; }

    public string? PreviousOpNo { get; set; }

    public string? NextOpNo { get; set; }

    public bool? EditLock { get; set; }

    public DateTime? OpLastMovedDate { get; set; }

    public string? Remarks { get; set; }

    public int? ProgrammStatus { get; set; }

    public string? ProgrammNo { get; set; }

    public int? RedLine { get; set; }

    public int? MoveToQty { get; set; }

    public string? ColorNo { get; set; }

    public string? ColorId { get; set; }

    public string? SpecId { get; set; }

    public string? SpecNo { get; set; }

    public decimal? OpSequence { get; set; }

    public DateTime? RealStartTime { get; set; }

    public DateTime? RealStopTime { get; set; }

    public decimal? OpPriority { get; set; }

    public decimal? StandardHours { get; set; }

    public decimal? AppliedHours { get; set; }

    public decimal? Variance { get; set; }

    public string? OpNoSortOrder { get; set; }

    public bool? LastSetup { get; set; }

    public decimal? OldOpPriority { get; set; }

    public bool? ProgramCompleted { get; set; }

    public decimal? UpdateOpPriority { get; set; }

    public bool? Freeze { get; set; }

    public string? CustomOpNo { get; set; }

    public string? CustomNextOpNo { get; set; }

    public string? CustomPreviousOpNo { get; set; }

    public string? ProgramNote { get; set; }

    public int? ClockIn { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public decimal? KronosAdjustedHours { get; set; }

    public string? OpId { get; set; }
}
