using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderCompletionDate
{
    public string WorkOrderId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WorkOrderDesc { get; set; }

    public DateTime? QmsreleaseDate { get; set; }

    public DateTime? QmsplanStopTime { get; set; }

    public DateTime? OracleCloseDate { get; set; }
}
