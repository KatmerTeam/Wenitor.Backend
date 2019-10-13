using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Katmer.Wenitor
{
    public class TargetSelector : AuditedAggregateRoot<Guid>
    {
        public SelectorType SelectorType {get; set;}
        public string ExpressionString { get; set; }
    }
}
