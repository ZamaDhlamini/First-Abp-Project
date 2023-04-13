using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NewAbpProject.Services.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Course_s
{
    public interface ICourseAppService: IApplicationService
    {
        Task<CourseDto> CreateAsync(CourseDto input);
        Task<CourseDto> UpdateAsync(CourseDto input);
        Task<PagedResultDto<CourseDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<CourseDto>> GetAsync(PagedAndSortedResultRequestDto input, Guid id);
        Task DeleteAsync(Guid id);
    }
}
