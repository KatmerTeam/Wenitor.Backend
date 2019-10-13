using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Katmer.Wenitor
{
    public class TargetSource : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string WebURL { get; set; }
        public TargetSelector[] TargetSelectors { get; set; }
        public ScheduleCheck ScheduleCheck { get; set;}
        public Alert[] Alerts { get; set; }
    }
}
