using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentPortalApp.Core.Models;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.ViewModels;

namespace StudentPortalApp.Core.Commands
{
    public class LoginCommand : MCommand, ILoginCommand
    {
        public LoginCommand(ILoginService loginService)
        {
            _loginService = loginService;
        }

        private IViewModel<LoginModel> _viewModel;
        private ILoginService _loginService;
        

        public override void Execute(object parameter)
        {
            
        }

        public override bool CanExecute()
        {
            return true;
        }
    }
}
