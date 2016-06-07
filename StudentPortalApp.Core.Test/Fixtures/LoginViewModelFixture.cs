using System;
using MvvmCross.Core.Platform;
using MvvmCross.Core.Views;
using MvvmCross.Platform.Core;
using MvvmCross.Platform.IoC;
using NSubstitute;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.Test.Mocks;
using StudentPortalApp.Core.Test.Setup;

namespace StudentPortalApp.Core.Test.Fixtures
{
    public class LoginViewModelFixture : IDisposable
    {
        public void Dispose()
        {
            
        }

        public void Init(LoginViewModelTest test)
        {
            test.ClearAll();
            

            MvvmCrossTestSetup.Execute();
            InitialiseIoc(test.Container);
        }

        private static void InitialiseIoc(IMvxIoCProvider ioc)
        {
            ioc.RegisterType(() => Substitute.For<ILoginService>());
        }
    }
}