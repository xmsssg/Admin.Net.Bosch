using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FHeatTreatementBatchInfo
{
    public string BatchId { get; set; } = null!;

    public string? OrgId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public string? ResId { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool IsFinished { get; set; }

    public decimal? Duration { get; set; }

    public decimal? BatchNo { get; set; }
}
