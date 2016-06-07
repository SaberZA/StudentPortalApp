using NSubstitute;
using StudentPortalApp.Core.Commands;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.Test.Fixtures;
using StudentPortalApp.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StudentPortalApp.Core.Test.CommandTests
{
    public class LoginCommandTest : KcmfMvxIoCSupportingTest, IClassFixture<LoginCommandFixture>
    {
        public LoginCommandTest(LoginCommandFixture fixture)
        {
            fixture.Init(this);
        }

        [Fact]
        public void Execute_GivenLoginCommand_ShouldCallLoginService()
        {
            // Arrange
            var loginService = Substitute.For<ILoginService>();
            var loginViewModel = Substitute.For<ILoginViewModel>();

            var loginCommand = new LoginCommand(loginService, loginViewModel);
            var username = "user";
            var password = "test";

            //Act
            loginViewModel.Username = username;
            loginViewModel.Password = password;
            loginCommand.Execute();

            //Assert
            loginService.Received().AuthenticateUser(username, password);
        }
    }
}
