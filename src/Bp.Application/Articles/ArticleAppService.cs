using Bp.Contracts;
using Bp.Domain;
using Bp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Bp.Articles
{
    public class ArticleAppService : CrudAppService<Article, ArticleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateArticleDto>, IArticleAppService
    {
        public ArticleAppService(IRepository<Article, Guid> repository):base(repository)
        {

        }
    }
}
