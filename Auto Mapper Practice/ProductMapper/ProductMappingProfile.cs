using AutoMapper;

namespace Auto_Mapper_Practice.ProductMapper
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.Description));

            CreateMap<ProductCreateDTO, Product>();
        }

        //  CreateMap<TSource, TDestination>() 
        //  Map<TDestination>(object source)
        //  var productDTO = _mapper.Map<ProductDTO>(product);
    }
}
