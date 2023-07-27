using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FFeedbackStatistic
{
    public string FeedbackStatisticId { get; set; } = null!;

    public string? PartNo { get; set; }

    public string? PartName { get; set; }

    public string? OpNo { get; set; }

    public string? OpName { get; set; }

    public int? UnsignedQty { get; set; }

    public string OrgId { get; set; } = null!;

    public string? Workorderno { get; set; }

    public string? ResList { get; set; }

    public int? QualifiedQtySum { get; set; }

    public DateTime? BeginTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool? IsAssigned { get; set; }
}
