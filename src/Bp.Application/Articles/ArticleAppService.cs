using Bp.Contracts;
using Bp.Domain;
using Bp.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Bp.Articles
{
    public class ArticleAppService : CrudAppService<Article, ArticleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateArticleDto>, IArticleAppService
    {
        private IRepository<Article, Guid> repository;
        public ArticleAppService(IRepository<Article, Guid> repository) : base(repository)
        {
            this.repository = repository;
            RefreshArticles();
        }
        public void RefreshArticles()
        {
            var json = FetchExternalSources();
            var articles = JsonToArticle(json);
            var articlesInDb = this.repository.GetListAsync();
            var result = articles.Where(p => articlesInDb.Result.All(p2 => p2.Title != p.Title));
            this.repository.InsertManyAsync(result);
        }

        public string FetchExternalSources()
        {
            var url = "https://newsapi.org/v2/top-headlines?country=bg&apiKey=a996d1bafb4f474f8dd6ed9cee826da4";
            var json = new WebClient().DownloadString(url);
            return json;
        }
        public IEnumerable<Article> JsonToArticle(string jsonString)
        {
            var apiResponse = JsonConvert.DeserializeObject<NewsApiResponse>(jsonString);
            return apiResponse.Articles;
        }
    }
}
