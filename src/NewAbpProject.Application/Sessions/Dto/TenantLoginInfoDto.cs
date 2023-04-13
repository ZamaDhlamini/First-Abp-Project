using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NewAbpProject.MultiTenancy;

namespace NewAbpProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
