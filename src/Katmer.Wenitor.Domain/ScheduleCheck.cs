using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Katmer.Wenitor
{
    public class ScheduleCheck : AuditedAggregateRoot<Guid>
    {
        public ScheduleType ScheduleType { get; set; }
        public int Duration { get; set; }
    }
}
