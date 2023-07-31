using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderOpResSkill
{
    public string WoopResSkillId { get; set; } = null!;

    public string WoopId { get; set; } = null!;

    public string WoopResId { get; set; } = null!;

    public string? SkillId { get; set; }

    public int? DemandQty { get; set; }

    public string? OrgId { get; set; }
}
