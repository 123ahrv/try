using AutoMapper;
using Employee_Exercise.Models.DTO;

namespace Employee_Exercise.Models
{
    public class EmployeeProfile:Profile
    {
        static int  ID=0;
        public EmployeeProfile()
        {
            ID++;
            CreateMap<EmployeeDto, Employee>()
                .ForMember(d => d.FullName, i => i.MapFrom(o => o.FirstName + " " + o.LastName))
                .ForMember(d => d.FullName, i => i.MapFrom(o => o.FirstName + " " + o.LastName))
                .ForMember(d => d.Id, i => i.MapFrom(o=>ID));
      
        }
    }
}
