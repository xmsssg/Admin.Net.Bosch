using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BPeopleMachine
{
    public string Id { get; set; } = null!;

    public int? Type { get; set; }

    public string? TableHtml { get; set; }

    public string? OrgId { get; set; }
}
