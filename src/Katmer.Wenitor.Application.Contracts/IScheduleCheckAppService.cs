using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    public interface IScheduleCheckAppService :
        ICrudAppService<ScheduleCheckDTO, Guid, PagedAndSortedResultRequestDto, ScheduleCheckDTO, ScheduleCheckDTO>
    {
    }
}
