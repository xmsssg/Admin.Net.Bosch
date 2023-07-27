using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BOperationNote
{
    public string NoteId { get; set; } = null!;

    public string? WorkOrderId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WoopId { get; set; }

    public string? OpNo { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? IntegrationDate { get; set; }

    public string? OrgId { get; set; }
}
