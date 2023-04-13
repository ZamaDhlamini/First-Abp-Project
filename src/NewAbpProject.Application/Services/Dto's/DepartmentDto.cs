using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NewAbpProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Dto_s
{
    [AutoMap(typeof(Department))]
    public class DepartmentDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
