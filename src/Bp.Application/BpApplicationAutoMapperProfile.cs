using AutoMapper;
using Bp.Domain;
using Bp.Dtos;

namespace Bp
{
    public class BpApplicationAutoMapperProfile : Profile
    {
        public BpApplicationAutoMapperProfile()
        {
            CreateMap<Article, ArticleDto>();
        }
    }
}
