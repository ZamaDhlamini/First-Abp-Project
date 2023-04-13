using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Dto_s
{
    public class CourseDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public Guid? DepartmentId { get; set; }
    }
}
