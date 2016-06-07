using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core;
using MvvmCross.Core.Platform;
using MvvmCross.Platform.Core;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using NSubstitute;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.Test.Mocks;
using StudentPortalApp.Core.ViewModels;

namespace StudentPortalApp.Core.Test.Setup
{
    public static class MvvmCrossTestSetup
    {
        //public static void Execute()
        //{
        //    Execute(new NullSingletonRegisterer());
        //}

        public static IMvxIoCProvider Execute()
        {
            MvxSingleton.ClearAllSingletons();
            var ioc = MvxSimpleIoCContainer.Initialize();

            var dispatcher = new InlineMockMainThreadDispatcher();
            
            ioc.RegisterSingleton(dispatcher);
            ioc.RegisterSingleton<IMvxMainThreadDispatcher>(dispatcher);

            // for navigation parsing
            ioc.RegisterSingleton<IMvxStringToTypeParser>(new MvxStringToTypeParser());
            
            ioc.RegisterSingleton(ioc);
            ioc.RegisterSingleton<IMvxTrace>(new TestTrace());
            //singletonRegisterer.RegisterSingletons(ioc);
            InitialiseSingletonCache();
            InitialiseMvxSettings(ioc);

            MvxTrace.Initialize();

            return ioc;
        }

        

        private static void InitialiseMvxSettings(IMvxIoCProvider ioc)
        {
            ioc.RegisterSingleton<IMvxSettings>(new MvxSettings());
        }

        private static void InitialiseSingletonCache()
        {
            MvxSingletonCache.Initialize();
        }

        private class TestTrace : IMvxTrace
        {
            /* unchanged ... */
            public void Trace(MvxTraceLevel level, string tag, Func<string> message)
            {
                Debug.WriteLine(message());
            }

            public void Trace(MvxTraceLevel level, string tag, string message)
            {
                Debug.WriteLine(message);
            }

            public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
            {
                Debug.WriteLine(message);
            }
        }
    }
}
