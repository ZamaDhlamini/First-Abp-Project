using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NewAbpProject.EntityFrameworkCore;
using NewAbpProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NewAbpProject.Web.Tests
{
    [DependsOn(
        typeof(NewAbpProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NewAbpProjectWebTestModule : AbpModule
    {
        public NewAbpProjectWebTestModule(NewAbpProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewAbpProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NewAbpProjectWebMvcModule).Assembly);
        }
    }
}