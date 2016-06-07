using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using PropertyChanged;
using StudentPortalApp.Core.Commands;
using StudentPortalApp.Core.Models;
using StudentPortalApp.Core.Services;

namespace StudentPortalApp.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class LoginViewModel : MvxViewModel, IViewModel<LoginModel>
    {
        private readonly ILoginCommand _loginCommand;

        public LoginViewModel(
            ILoginService loginService,
            ILoginCommand loginCommand)
        {
            Login = loginCommand.Init(this, loginService);
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginModel Model { get; set; }

        public ILoginCommand Login { get; set; }
        public IAuthCommand AuthCommand { get; set; }
    }

    public interface IAuthCommand : ICommand
    {
    }

    public interface ILoginCommand : IMvxCommand
    {
        ILoginCommand Init(IViewModel<LoginModel> loginViewModel, ILoginService loginService);
    }

    public class AuthTokenModel
    {
    }

    public interface IViewModel<T>
    {
        T Model { get; set; }
    }
}
