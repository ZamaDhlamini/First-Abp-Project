using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using NewAbpProject.Domain;
using NewAbpProject.Services.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Course_s
{
    public class CourseAppService : ApplicationService, ICourseAppService
    {


        private readonly IRepository<Course, Guid> _repository;
        private readonly IRepository<Department, Guid> _department;

        public CourseAppService(IRepository<Course, Guid> repository, IRepository<Department, Guid> department)
        {
            _repository = repository;
            _department = department;
        }

        public async Task<CourseDto> CreateAsync(CourseDto input)
        {
            var course = ObjectMapper.Map<Course>(input);
            course.Department = await _department.GetAsync((Guid)input.DepartmentId);
            await _repository.InsertAsync(course);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<CourseDto>(course);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<CourseDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            try
            {
                var query = _repository.GetAllIncluding(m => m.Department);
                var result = new PagedResultDto<CourseDto>();
                result.TotalCount = query.Count();
                result.Items = ObjectMapper.Map<IReadOnlyList<CourseDto>>(query);
                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<PagedResultDto<CourseDto>> GetAsync(PagedAndSortedResultRequestDto input, Guid id)
        {
            try
            {
                var query = _repository.GetAllIncluding(m => m.Department);
                var res = query.Where(x => x.Id == id);
                var result = new PagedResultDto<CourseDto>();
                result.Items = ObjectMapper.Map<IReadOnlyList<CourseDto>>(res);
                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Task<CourseDto> UpdateAsync(CourseDto input)
        {
            throw new NotImplementedException();
        }
    }
}
