using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FWorkOrderBom
{
    public string Wobomid { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? MasterWorkOrderId { get; set; }

    public string? MasterWorkOrderNo { get; set; }

    public string? SubWorkOrderId { get; set; }

    public string? RootWorkOrderId { get; set; }

    public decimal? NeedQty { get; set; }

    public string? OpNo { get; set; }

    public string? PartId { get; set; }

    public string? PartNo { get; set; }

    public decimal? AllocatedQty { get; set; }

    public decimal? ShortageQty { get; set; }

    public string? MakeorBuy { get; set; }
}
