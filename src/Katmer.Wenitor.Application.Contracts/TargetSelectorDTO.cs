using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Katmer.Wenitor
{
    public class TargetSelectorDTO : AuditedEntityDto<Guid>
    {
        public SelectorType SelectorType {get; set;}
        public string ExpressionString { get; set; }
    }
}
