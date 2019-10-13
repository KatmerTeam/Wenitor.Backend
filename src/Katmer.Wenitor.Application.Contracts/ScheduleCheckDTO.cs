using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Katmer.Wenitor
{
    public class ScheduleCheckDTO : AuditedEntityDto<Guid>
    {
        public ScheduleType ScheduleType { get; set; }
        public int Duration { get; set; }
    }
}
