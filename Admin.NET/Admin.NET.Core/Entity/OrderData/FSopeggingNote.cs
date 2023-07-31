using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSopeggingNote
{
    public string Guid { get; set; } = null!;

    public string SopeggingId { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Type { get; set; }

    public string? OrgId { get; set; }
}
