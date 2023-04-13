using Abp.Application.Services;
using NewAbpProject.MultiTenancy.Dto;

namespace NewAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

