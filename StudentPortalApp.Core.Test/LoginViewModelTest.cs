using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Core;
using MvvmCross.Test.Core;
using NSubstitute;
using StudentPortalApp.Core.Test.Fixtures;
using StudentPortalApp.Core.ViewModels;
using Xunit;

namespace StudentPortalApp.Core.Test
{
    public class LoginViewModelTest : MvxIoCSupportingTest, IClassFixture<LoginViewModelFixture>
    {
        public LoginViewModelTest(LoginViewModelFixture fixture)
        {
            fixture.Init(this);
        }

        [Fact]
        public void Username_SetViewModelLogin_User1()
        {
            // Arrange
            var loginViewModel = new LoginViewModel();
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
            var loginViewModel = new LoginViewModel();
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
            var loginViewModel = new LoginViewModel();
            loginViewModel.PropertyChanged += (sender, args) =>
            {
                receivedPropertyChanged = args.PropertyName;
            };

            //Act
            loginViewModel.Password = "test";

            //Assert
            Assert.Equal("Password", receivedPropertyChanged);
        }
        
        public new void ClearAll()
        {
            base.ClearAll();
        }

        public void RegisterSingleton(IMvxMainThreadDispatcher dispatcher)
        {
            Ioc.RegisterSingleton(dispatcher);
        }
    }
}
