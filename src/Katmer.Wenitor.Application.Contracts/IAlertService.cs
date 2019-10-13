using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    public interface IAlertService :
        ICrudAppService<AlertDTO,Guid,PagedAndSortedResultRequestDto,AlertDTO,AlertDTO>
    {
    }
}
