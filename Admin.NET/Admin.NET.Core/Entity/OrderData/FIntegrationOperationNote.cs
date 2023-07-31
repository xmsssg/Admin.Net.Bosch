using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FIntegrationOperationNote
{
    public string Id { get; set; } = null!;

    public string? WorkOrderNo { get; set; }

    public double WoTextKey { get; set; }

    public string? WoTextId { get; set; }

    public double WoOperationKey { get; set; }

    public double? WoHeaderKey { get; set; }

    public string? WoId { get; set; }

    public string? CompanyId { get; set; }

    public string? BusinessLocationId { get; set; }

    public string? BusinessLocationCode { get; set; }

    public double? OperationSequenceNumber { get; set; }

    public string? OperationNotesShortText { get; set; }

    public string? OperationNotesLongText { get; set; }

    public DateTime? ErpCreationDate { get; set; }

    public string? ErpCreationDateId { get; set; }

    public DateTime? ErpUpdateDate { get; set; }

    public string? RecordSourceName { get; set; }

    public DateTime? RecordProcessedDate { get; set; }

    public string? RecordProcessedId { get; set; }

    public DateTime? IntegrationDate { get; set; }

    public string? Guid { get; set; }

    public string? OrgId { get; set; }
}
