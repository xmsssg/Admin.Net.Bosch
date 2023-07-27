using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWhatIfWorkOrderOpResSkill
{
    public string WhatIfWoopResSkillId { get; set; } = null!;

    public string WhatIfWoopId { get; set; } = null!;

    public string WhatIfWoopResId { get; set; } = null!;

    public string? SkillId { get; set; }

    public int? DemandQty { get; set; }

    public string? OrgId { get; set; }
}
