using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoIntegrationBom
{
    public string Guid { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string PartId { get; set; } = null!;

    public string? PartNo { get; set; }

    public string? OrganizationId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? NeedOpNo { get; set; }

    public int? DemandQty { get; set; }

    public int? IssuedQty { get; set; }

    public int? LeftQty { get; set; }

    public string? BasisType { get; set; }

    public string? OrgId { get; set; }

    public string? MakeorBuy { get; set; }
}
