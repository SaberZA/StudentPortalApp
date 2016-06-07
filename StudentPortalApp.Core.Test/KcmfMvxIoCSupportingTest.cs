using MvvmCross.Platform.IoC;
using MvvmCross.Test.Core;

namespace StudentPortalApp.Core.Test
{
    public class KcmfMvxIoCSupportingTest : MvxIoCSupportingTest
    {
        public KcmfMvxIoCSupportingTest()
        {
        }

        public IMvxIoCProvider Container => Ioc;

        public new void ClearAll() => base.ClearAll();
    }
}