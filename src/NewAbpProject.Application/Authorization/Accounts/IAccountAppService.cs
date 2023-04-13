using System.Threading.Tasks;
using Abp.Application.Services;
using NewAbpProject.Authorization.Accounts.Dto;

namespace NewAbpProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
