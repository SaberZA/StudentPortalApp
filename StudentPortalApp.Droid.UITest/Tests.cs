using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace StudentPortalApp.Droid.UITest
{
    [TestFixture]
    public class Tests
    {
        IApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp.Android
                .ApkFile(@"C:\Published\StudentPortalApp-aligned.apk")
                .EnableLocalScreenshots()
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
    }
}

