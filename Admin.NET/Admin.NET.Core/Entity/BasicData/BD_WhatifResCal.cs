﻿using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BWhatifResCal
{
    public string ResId { get; set; } = null!;

    public string CalId { get; set; } = null!;

    public int? Priority { get; set; }

    public string? OrgId { get; set; }
}
