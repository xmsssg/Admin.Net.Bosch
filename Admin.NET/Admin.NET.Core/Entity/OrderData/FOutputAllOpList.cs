using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FOutputAllOpList
{
    public string Guid { get; set; } = null!;

    public string? SoNo { get; set; }

    public string? WorkOrderNo { get; set; }

    public decimal? DemandQty { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemDesc { get; set; }

    public string? OperationNo { get; set; }

    public string? OperationDesc { get; set; }

    public string? ResNo { get; set; }

    public string? ResDesc { get; set; }

    public decimal? ResSetup { get; set; }

    public DateTime? PreviousStopTime { get; set; }

    public DateTime? StopTime { get; set; }

    public string? OrgId { get; set; }

    public decimal? PegId { get; set; }

    public decimal? PrePegId { get; set; }

    public decimal? RootPegId { get; set; }

    public DateTime? SetupStartTime { get; set; }

    public DateTime? ProcessStartTime { get; set; }
}
