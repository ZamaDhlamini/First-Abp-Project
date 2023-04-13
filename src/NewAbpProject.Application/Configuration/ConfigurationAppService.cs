﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NewAbpProject.Configuration.Dto;

namespace NewAbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NewAbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
