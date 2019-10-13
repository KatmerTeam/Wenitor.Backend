using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    public interface IScheduleCheckService :
        ICrudAppService<ScheduleCheckDTO, Guid, PagedAndSortedResultRequestDto, ScheduleCheckDTO, ScheduleCheckDTO>
    {
    }
}
