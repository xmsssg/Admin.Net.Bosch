using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class BLaborGroupSkill
{
    public string Id { get; set; } = null!;

    public string LaborGroupId { get; set; } = null!;

    public string SkillId { get; set; } = null!;
}
