using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderUptBack
{
    public string Id { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public int? DemandQty { get; set; }

    public int? ModelNum { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
