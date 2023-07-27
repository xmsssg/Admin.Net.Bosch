using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FExportWorkOrder
{
    public string WorkOrderId { get; set; } = null!;

    public string? OrgId { get; set; }
}
