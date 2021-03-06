﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    public interface ITargetSourceAppService :
        ICrudAppService<TargetSourceDTO,Guid,PagedAndSortedResultRequestDto,TargetSourceDTO,TargetSourceDTO>
    {
    }
}
