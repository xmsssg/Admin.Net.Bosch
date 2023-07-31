using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BSkill
{
    public string SkillId { get; set; } = null!;

    public string? SkillNo { get; set; }

    public string? SkillName { get; set; }

    public string? OrgId { get; set; }
}
