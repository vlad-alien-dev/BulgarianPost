using Bp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Bp.Contracts
{
    public interface IArticleAppService:ICrudAppService<ArticleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateArticleDto>
    {

    }
}
