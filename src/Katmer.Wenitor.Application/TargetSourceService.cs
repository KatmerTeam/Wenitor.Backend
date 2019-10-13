using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class TargetSourceService :
        CrudAppService<TargetSource, TargetSourceDTO, Guid, PagedAndSortedResultRequestDto,TargetSourceDTO, TargetSourceDTO>,
        ITargetSourceService
    {
        public TargetSourceService(IRepository<TargetSource, Guid> repository) : base(repository)
        {

        }
    }
}
