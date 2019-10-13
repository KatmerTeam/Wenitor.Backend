using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class TargetSourceAppService :
        CrudAppService<TargetSource, TargetSourceDTO, Guid, PagedAndSortedResultRequestDto,TargetSourceDTO, TargetSourceDTO>,
        ITargetSourceAppService
    {
        public TargetSourceAppService(IRepository<TargetSource, Guid> repository) : base(repository)
        {

        }
    }
}
