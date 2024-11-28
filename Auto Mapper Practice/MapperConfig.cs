using AutoMapper;

namespace Auto_Mapper_Practice
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, AddressDTO>()
                .ForMember(dest => dest.EmpCity, act => act.MapFrom(src => src.City))
                .ForMember(dest => dest.EmpState, act => act.MapFrom(src => src.State))
                .ReverseMap();

                cfg.CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.Dept, act => act.MapFrom(src => src.Department))
                .ForMember(dest => dest.AddressDTO, act => act.MapFrom(src => src.Address))
                .ReverseMap();
            });

            var mapper = new Mapper(config);

            return mapper;
        }

    }
}
