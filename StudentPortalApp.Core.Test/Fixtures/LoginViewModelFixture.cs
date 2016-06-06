using System;
using StudentPortalApp.Core.Test.Mocks;

namespace StudentPortalApp.Core.Test.Fixtures
{
    public class LoginViewModelFixture : IDisposable
    {
        public void Dispose()
        {
            
        }

        public void Init(LoginViewModelTest mvxIoCSupportingTest)
        {
            mvxIoCSupportingTest.ClearAll();
            var dispatcher = new InlineMockMainThreadDispatcher();
            mvxIoCSupportingTest.RegisterSingleton(dispatcher);
        }
    }
}