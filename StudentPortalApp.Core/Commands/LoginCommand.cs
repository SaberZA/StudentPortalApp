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
        public LoginCommand(ILoginService loginService, ILoginViewModel viewModel)
        {
            _loginService = loginService;
            _viewModel = viewModel;
        }

        private ILoginViewModel _viewModel;
        private ILoginService _loginService;

        public override void Execute(object parameter)
        {
            _loginService.AuthenticateUser(_viewModel.Username, _viewModel.Password);
        }

        public override bool CanExecute()
        {
            return true;
        }
    }
}
