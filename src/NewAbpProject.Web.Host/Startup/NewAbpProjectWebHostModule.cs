using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NewAbpProject.Configuration;

namespace NewAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(NewAbpProjectWebCoreModule))]
    public class NewAbpProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NewAbpProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewAbpProjectWebHostModule).GetAssembly());
        }
    }
}
