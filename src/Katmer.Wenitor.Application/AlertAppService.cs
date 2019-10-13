using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class AlertAppService :
        CrudAppService<Alert, AlertDTO, Guid, PagedAndSortedResultRequestDto, AlertDTO, AlertDTO>,
        IAlertAppService
    {
        public AlertAppService(IRepository<Alert, Guid> repository) : base(repository)
        {

        }
    }
}
