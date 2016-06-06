using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Core;

namespace StudentPortalApp.Core.Test.Mocks
{
    public class InlineMockMainThreadDispatcher
        : MvxMainThreadDispatcher
          , IMvxMainThreadDispatcher
    {
        public virtual bool RequestMainThreadAction(Action action)
        {
            action();
            return true;
        }
    }
}
