using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Bp.Articles
{
    public class Article : AuditedAggregateRoot<Guid>
    {
        public string Author { get; set; }
        public string Title { get; set; }

    }
}
