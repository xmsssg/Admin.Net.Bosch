using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FHeatTreatementBatchDetail
{
    public string BatchDetailId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? BatchId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public string? WorkOrderId { get; set; }

    public string? WoopId { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public decimal? Duration { get; set; }
}
