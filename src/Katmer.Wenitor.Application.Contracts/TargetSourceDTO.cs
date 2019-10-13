using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Katmer.Wenitor
{
    public class TargetSourceDTO : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string WebURL { get; set; }
        public TargetSelectorDTO[] TargetSelectors { get; set; }
        public ScheduleCheckDTO ScheduleCheck { get; set;}
        public AlertDTO[] Alerts { get; set; }
    }
}
