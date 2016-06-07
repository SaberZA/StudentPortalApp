using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using StudentPortalApp.Core.Models;
using StudentPortalApp.Core.ViewModels;

namespace StudentPortalApp.Core.Commands
{
    public class LoginCommand : IMvxCommand
    {
        private IViewModel<LoginModel> _viewModel;

        public LoginCommand(IViewModel<LoginModel> viewModel)
        {
            _viewModel = viewModel;
        }

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
    }
}
