using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Katmer.Wenitor
{
    public class Alert : AuditedAggregateRoot<Guid>
    {
        public AlertType AlertType { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
    }
}
