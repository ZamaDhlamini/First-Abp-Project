using AutoMapper;
using NewAbpProject.Domain;
using NewAbpProject.Services.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Course_s
{
    internal class CourseMappProfile: Profile
    {
        public CourseMappProfile() {
            CreateMap<Course, CourseDto>()
            .ForMember(e => e.DepartmentId, m => m.MapFrom(e => e.Department != null && e.Department != null ? e.Department.Id :(Guid?)null));

            CreateMap<CourseDto, Course>()
                .ForMember(e => e.Id, d => d.Ignore());
            
        }
    }
}
