using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NewAbpProject.Services.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Departments
{
    public interface IDepartmentAppService : IAsyncCrudAppService<DepartmentDto, Guid, PagedAndSortedResultRequestDto>
    {

    }
    
}
