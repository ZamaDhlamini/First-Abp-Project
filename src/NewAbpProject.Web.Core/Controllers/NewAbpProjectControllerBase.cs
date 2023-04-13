using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NewAbpProject.Controllers
{
    public abstract class NewAbpProjectControllerBase: AbpController
    {
        protected NewAbpProjectControllerBase()
        {
            LocalizationSourceName = NewAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
