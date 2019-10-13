using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    public interface ITargetSourceService :
        ICrudAppService<TargetSourceDTO,Guid,PagedAndSortedResultRequestDto,TargetSourceDTO,TargetSourceDTO>
    {
    }
}
