using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class ScheduleCheckService :
        CrudAppService<ScheduleCheck, ScheduleCheckDTO, Guid, PagedAndSortedResultRequestDto, ScheduleCheckDTO, ScheduleCheckDTO>,
        IScheduleCheckService
    {
        public ScheduleCheckService(IRepository<ScheduleCheck, Guid> repository) : base(repository)
        {

        }
    }
}
