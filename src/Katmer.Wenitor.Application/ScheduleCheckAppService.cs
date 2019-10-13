using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class ScheduleCheckAppService :
        CrudAppService<ScheduleCheck, ScheduleCheckDTO, Guid, PagedAndSortedResultRequestDto, ScheduleCheckDTO, ScheduleCheckDTO>,
        IScheduleCheckAppService
    {
        public ScheduleCheckAppService(IRepository<ScheduleCheck, Guid> repository) : base(repository)
        {

        }
    }
}
