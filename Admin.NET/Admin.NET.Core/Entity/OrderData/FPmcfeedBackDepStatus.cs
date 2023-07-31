using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FPmcfeedBackDepStatus
{
    public string FbDepStatusId { get; set; } = null!;

    public string? ReponsibleDepNo { get; set; }

    public string? ReponsibleDepName { get; set; }

    public string? OrgId { get; set; }

    public bool IsSettled { get; set; }

    public string? PmcfeedBcakGuid { get; set; }
}
