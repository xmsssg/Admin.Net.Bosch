using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FSoIntegrationKronosFeedback
{
    public string Guid { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? OrganizationId { get; set; }

    public string? OrgId { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime? StopDateTime { get; set; }

    public string? WorkOrderNumber { get; set; }

    public string? OperationNumber { get; set; }

    public decimal CompleteFlag { get; set; }

    public decimal QuantityComplete { get; set; }

    public decimal QuantityScrapped { get; set; }

    public decimal AdjustedHours { get; set; }

    public string? ResourceSequence { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }
}
