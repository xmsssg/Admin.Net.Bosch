using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoInventoryOnHand
{
    public string Id { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public string? OrganizationId { get; set; }

    public string? OrgId { get; set; }

    public string PartNo { get; set; } = null!;

    public string? SubInventoryCode { get; set; }

    public string? Locator { get; set; }

    public decimal? QtyOnHand { get; set; }

    public string? WorkOrderNo { get; set; }

    public decimal? QtyReserved { get; set; }

    public DateTime? EtlinsertDate { get; set; }

    public string? Lot { get; set; }

    public string? Serial { get; set; }

    public string? Location { get; set; }

    public string? Sublocation { get; set; }
}
