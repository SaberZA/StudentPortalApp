using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using StudentPortalApp.Core.Models;
using StudentPortalApp.Core.Services;
using StudentPortalApp.Core.ViewModels;

namespace StudentPortalApp.Core.Commands
{
    public class LoginCommand : ILoginCommand
    {
        private IViewModel<LoginModel> _viewModel;
        private ILoginService _loginService;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }

        public event EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            
        }

        public void Execute()
        {
            
        }

        public bool CanExecute()
        {
            return true;
        }

        public ILoginCommand Init(IViewModel<LoginModel> viewModel, ILoginService loginService)
        {
            _loginService = loginService;
            _viewModel = viewModel;
            

            return this;
        }
    }
}
