using AutoMapper;

using OnlineStore.Categories;

namespace OnlineStore.Mappings
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateUpdateCategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
