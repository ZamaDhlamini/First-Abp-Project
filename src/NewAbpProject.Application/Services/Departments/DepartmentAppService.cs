
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using NewAbpProject.Domain;
using NewAbpProject.Services.Dto_s;
using System;

namespace NewAbpProject.Services.Departments
{
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, Guid, PagedAndSortedResultRequestDto>, IDepartmentAppService
    {
        private readonly IRepository<Department, Guid> _repository;

        public DepartmentAppService(IRepository<Department, Guid> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
