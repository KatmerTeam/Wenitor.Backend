using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    public interface ITargetSelectorService :
        ICrudAppService<TargetSelectorDTO, Guid, PagedAndSortedResultRequestDto, TargetSelectorDTO, TargetSelectorDTO>
    {
    }
}
