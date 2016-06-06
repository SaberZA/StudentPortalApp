using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform.Core;

namespace StudentPortalApp.Core.Test.Mocks
{
    public class MockMvxViewDispatcher : MvxMainThreadDispatcher, IMvxViewDispatcher
    {
        private readonly IMvxViewDispatcher _decorated;

        public MockMvxViewDispatcher(IMvxViewDispatcher decorated)
        {
            _decorated = decorated;
        }

        public bool ChangePresentation(MvxPresentationHint hint)
        {
            return _decorated.ChangePresentation(hint);
        }

        public bool RequestMainThreadAction(Action action)
        {
            return _decorated.RequestMainThreadAction(action);
        }

        public bool ShowViewModel(MvxViewModelRequest request)
        {
            return _decorated.ShowViewModel(request);
        }
    }
}
