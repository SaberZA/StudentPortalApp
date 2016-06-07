using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Core;
using NSubstitute;
using NSubstitute.Core;
using StudentPortalApp.Core.Commands;
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
            var loginViewModel = CreateLoginViewModel();
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

            var loginViewModel = CreateLoginViewModel();
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
            var loginViewModel = CreateLoginViewModel();
            loginViewModel.PropertyChanged += (sender, args) => { receivedPropertyChanged = args.PropertyName; };

            //Act
            loginViewModel.Password = "test";

            //Assert
            Assert.Equal("Password", receivedPropertyChanged);
        }



        // TODO: ADD TEST FOR IOCConstruct
        [Fact]
        public void IocConstruct_GivenLoginViewModel_ShouldReturnNotNull()
        {
            // Arrange
            
            //Act
            var loginViewModel = Ioc.IoCConstruct<LoginViewModel>();

            //Assert
            Assert.NotNull(loginViewModel);
        }

        [Fact]
        public void Constructor_SetLoginCommand_ExpectNotNull()
        {
            // Arrange

            //Act
            var loginViewModel = CreateLoginViewModel();

            //Assert
            Assert.NotNull(loginViewModel.Login);
        }

        [Fact]
        public void Execute_GivenLoginCommand_ShouldCallLoginService()
        {
            // Arrange
            var loginService = Substitute.For<ILoginService>();
            var loginCommand = new LoginCommand();
            var loginViewModel = CreateLoginViewModel(loginService, loginCommand);
            var username = "user";
            var password = "test";

            //Act
            loginViewModel.Username = username;
            loginViewModel.Password = password;
            loginViewModel.Login.Execute();

            //Assert
            loginService.Received().AuthenticateUser(username, password);
        }

        private static LoginViewModel CreateLoginViewModel(ILoginService loginService, ILoginCommand loginCommand)
        {
            return new LoginViewModel(loginService, loginCommand);
        }

        private static LoginViewModel CreateLoginViewModel()
        {
            var loginService = Substitute.For<ILoginService>();
            var loginCommand = Substitute.For<ILoginCommand>();
            return new LoginViewModel(loginService, loginCommand);
        }
    }
}
