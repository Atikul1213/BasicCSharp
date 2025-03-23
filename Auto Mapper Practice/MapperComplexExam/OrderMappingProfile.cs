using Auto_Mapper_Practice.MapperComplexExam.DTO;
using AutoMapper;

namespace Auto_Mapper_Practice.MapperComplexExam
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            //  CreateMap<TSource, TDestination>() 
            //  Map<TDestination>(object source)

            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => $"{src.Customer.FirstName} {src.Customer.LastName}"))
                .ForMember(dest => dest.CustomerEmail, opt => opt.MapFrom(src => src.Customer.Email))
                .ForMember(dest => dest.CustomerPhoneNumber, opt => opt.MapFrom(src => src.Customer.PhoneNumber))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Customer.Address))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.OrderItems));


            CreateMap<OrderItem, OrderItemDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.Product.Price))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Product.Price * src.Quantity));


            CreateMap<OrderrCreateDTO, Order>()
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.Amount, opt => opt.Ignore())
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.Items));


            CreateMap<OrderItemCreateDTO, OrderItem>();


            CreateMap<UserCreateDTO, User>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => new AddressOuter
                {
                    Street = src.Street,
                    City = src.City,
                    State = src.State,
                    ZipCode = src.ZipCode
                }));
        }
    }
}
