using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class TargetSelectorAppService :
        CrudAppService<TargetSelector, TargetSelectorDTO, Guid, PagedAndSortedResultRequestDto, TargetSelectorDTO, TargetSelectorDTO>,
        ITargetSelectorAppService
    {
        public TargetSelectorAppService(IRepository<TargetSelector, Guid> repository) : base(repository)
        {

        }
    }
}
