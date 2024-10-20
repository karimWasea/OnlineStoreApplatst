using AutoMapper;

using OnlineStore.Products;

namespace OnlineStore.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<CreateUpdateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
