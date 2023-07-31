using System;
using System.Collections.Generic;

namespace Project.Model.Models;

public partial class FScheduleEmailInfoForException
{
    public string EmailNumber { get; set; } = null!;

    public string? From { get; set; }

    public string? ToAarry { get; set; }

    public string? CcAarry { get; set; }

    public string? Subject { get; set; }

    public string? Pwd { get; set; }

    public string? Host { get; set; }

    public string? Port { get; set; }

    public bool IsbodyHtml { get; set; }

    public string? Attachments { get; set; }

    public string? OrgId { get; set; }
}
