using Bp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;

namespace Bp
{
    public class BulgarianPostDataSeederContributor : IDataSeedContributor
    {
        private readonly IRepository<Article, Guid> _articleRepository;
        public BulgarianPostDataSeederContributor(IRepository<Article, Guid> articleRepository)
        {
            this._articleRepository = articleRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await this._articleRepository.GetCountAsync() <= 0)
            {
                await this._articleRepository.InsertAsync(
                    new Article
                    {
                        Author = "W. E. Gladstone",
                        Title = "Bulgarian Horrors and Question of The East"
                    });
                await this._articleRepository.InsertAsync(
                    new Article
                    {
                        Author = "J. Boucher",
                        Title = "Slaughter Lessons"
                    });
            }
        }
    }
}
