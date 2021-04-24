using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Bp.Dtos
{
    public class ArticleDto : AuditedEntityDto<Guid>
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
