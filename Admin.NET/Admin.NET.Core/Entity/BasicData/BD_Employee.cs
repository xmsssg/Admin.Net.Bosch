using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BEmployee
{
    public string? EmployeeName { get; set; }

    public string? EmployeeNum { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? OrgId { get; set; }
}
