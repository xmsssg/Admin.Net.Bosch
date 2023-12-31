﻿using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BMachinePerson
{
    public string Id { get; set; } = null!;

    public string? GroupNo { get; set; }

    public string? GroupDesc { get; set; }

    public string? ResNo { get; set; }

    public string? OrgId { get; set; }

    public int? MachineType { get; set; }

    public int? Maetype { get; set; }

    public int? ScheduleType { get; set; }

    public int? IsAvailable { get; set; }
}
