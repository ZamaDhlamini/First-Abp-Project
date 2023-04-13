using System.Threading.Tasks;
using NewAbpProject.Models.TokenAuth;
using NewAbpProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace NewAbpProject.Web.Tests.Controllers
{
    public class HomeController_Tests: NewAbpProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}