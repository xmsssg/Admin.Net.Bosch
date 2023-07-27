using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FScheduleException
{
    public string ExceptionNum { get; set; } = null!;

    public string? Exception { get; set; }

    public DateTime? TimeForAddingException { get; set; }

    public string? CaseId { get; set; }

    public string UserId { get; set; } = null!;

    public string? UserNo { get; set; }

    public bool? HasEmailed { get; set; }

    public string? OrgId { get; set; }
}
