using AutoMapper;

namespace Auto_Mapper_Practice.ReverseMap
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.Address.State))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Address.Country))
                .ReverseMap()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => GetFirstName(src.FullName)))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => GetLastName(src.FullName)));

            // var employeeDTOs = _mapper.Map<List<EmployeeDTO>>(employees);
            // var employeeDTO = _mapper.Map<EmployeeDTO>(employee);
            //  var employee = _mapper.Map<Employee>(employeeDTO);

        }

        private static string GetFirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return string.Empty;
            var names = fullName.Split(' ');
            return names.FirstOrDefault() ?? string.Empty;
        }
        private static string GetLastName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return string.Empty;
            var names = fullName.Split(' ');
            // If there is more than one word, combine the rest as the last name
            return names.Length > 1 ? string.Join(" ", names.Skip(1)) : string.Empty;
        }

    }
}
