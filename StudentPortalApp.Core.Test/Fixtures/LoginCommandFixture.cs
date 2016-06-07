using MvvmCross.Platform.IoC;
using NSubstitute;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.Test.Setup;
using StudentPortalApp.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalApp.Core.Test.Fixtures
{
    public class LoginCommandFixture : IDisposable
    {
        public void Dispose()
        {

        }

        public void Init(KcmfMvxIoCSupportingTest test)
        {
            test.ClearAll();
            MvvmCrossTestSetup.Execute();
            InitialiseIoc(test.Container);
        }

        private static void InitialiseIoc(IMvxIoCProvider ioc)
        {
            ioc.RegisterType(() => Substitute.For<ILoginService>());
            ioc.RegisterType(() => Substitute.For<ILoginViewModel>());
        }
    }
}
