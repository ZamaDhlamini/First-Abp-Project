using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NewAbpProject.Authorization;

namespace NewAbpProject
{
    [DependsOn(
        typeof(NewAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NewAbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NewAbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NewAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
