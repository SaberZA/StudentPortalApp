using NUnit.Framework;
using Xamarin.UITest;

namespace UITest1
{
    [TestFixture]
    public class Tests
    {
        IApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the iOS app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //app = ConfigureApp
            //    .iOS
            //    // TODO: Update this path to point to your iOS app and uncomment the
            //    // code if the app is not included in the solution.
            //    //.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/iOSUITest.iOS.app")
            //    .StartApp();
            //app = ConfigureApp.Android.StartApp();
            app = ConfigureApp.Android
                //.DeviceSerial("0756edf000620ace")
                .ApkFile(@"C:\Published\StudentPortalApp-aligned.apk")
                .EnableLocalScreenshots()
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            var firstScreenshotFile = app.Screenshot("First screen.");
        }
    }
}

