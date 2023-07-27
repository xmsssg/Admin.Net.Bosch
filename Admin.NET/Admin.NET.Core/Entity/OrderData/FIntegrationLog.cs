using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FIntegrationLog
{
    public string UpdateId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? UserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UserNo { get; set; }

    public string? UserName { get; set; }

    public bool IsUpdating { get; set; }

    public int? UpdateType { get; set; }

    public DateTime? FinishTime { get; set; }

    public decimal? TimeCost { get; set; }

    public string? CaseId { get; set; }

    public string? ErrorMsg { get; set; }
}
