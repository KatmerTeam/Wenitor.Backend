using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Katmer.Wenitor
{
    public class AlertService :
        CrudAppService<Alert, AlertDTO, Guid, PagedAndSortedResultRequestDto, AlertDTO, AlertDTO>,
        IAlertService
    {
        public AlertService(IRepository<Alert, Guid> repository) : base(repository)
        {

        }
    }
}
