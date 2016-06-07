using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Core;
using NSubstitute;
using NSubstitute.Core;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.Test.Fixtures;
using StudentPortalApp.Core.Test.Mocks;
using StudentPortalApp.Core.ViewModels;
using Xunit;

namespace StudentPortalApp.Core.Test
{
    public class LoginViewModelTest : KcmfMvxIoCSupportingTest, IClassFixture<LoginViewModelFixture>
    {
        public LoginViewModelTest(LoginViewModelFixture fixture) : base()
        {
            fixture.Init(this);
        }

        [Fact]
        public void Username_SetViewModelLogin_User1()
        {
            // Arrange
            var loginViewModel = new LoginViewModel(Substitute.For<ILoginService>(), Substitute.For<ILoginCommand>());
            //Act
            loginViewModel.Username = "User1";

            //Assert
            Assert.Equal(loginViewModel.Username, "User1");
        }        

        [Fact]
        public void Username_SetViewModelLogin_ShouldCallRaisePropertyChanged()
        {
            // Arrange
            var receivedPropertyChanged = "";

            var loginViewModel = new LoginViewModel(Substitute.For<ILoginService>(), Substitute.For<ILoginCommand>());
            loginViewModel.PropertyChanged += (sender, args) =>
            {
                receivedPropertyChanged = args.PropertyName;
            };

            //Act
            loginViewModel.Username = "User1";
            
            //Assert
            Assert.Equal("Username", receivedPropertyChanged);
        }

        [Fact]
        public void Password_SetViewModelLogin_ShouldCallRaisePropertyChanged()
        {
            // Arrange
            var receivedPropertyChanged = "";
            var loginViewModel = new LoginViewModel(Substitute.For<ILoginService>(), Substitute.For<ILoginCommand>());
            loginViewModel.PropertyChanged += (sender, args) => { receivedPropertyChanged = args.PropertyName; };

            //Act
            loginViewModel.Password = "test";

            //Assert
            Assert.Equal("Password", receivedPropertyChanged);
        }

        // TODO: ADD TEST FOR IOCConstruct
        
        [Fact]
        public void LoginService_LoginCommand_HasService()
        {
            // Arrange


            //Act
            var loginService = Substitute.For<ILoginService>();
            var loginCommand = Substitute.For<ILoginCommand>();

            var loginViewModel = Substitute.For<LoginViewModel>(loginService, loginCommand);

            //Assert
            Assert.NotNull(loginViewModel.Login);
            //loginViewModel.Login.Received().Init(loginViewModel, loginService);
            var receivedCalls = loginViewModel.Login.ReceivedCalls();
            //Assert.NotNull(loginViewModel.LoginService);
        }

        
    }
}
