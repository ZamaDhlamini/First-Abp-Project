using System.Threading.Tasks;
using Abp.Application.Services;
using NewAbpProject.Sessions.Dto;

namespace NewAbpProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
