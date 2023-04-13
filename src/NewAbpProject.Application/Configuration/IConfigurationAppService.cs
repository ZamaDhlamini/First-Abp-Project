using System.Threading.Tasks;
using NewAbpProject.Configuration.Dto;

namespace NewAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
