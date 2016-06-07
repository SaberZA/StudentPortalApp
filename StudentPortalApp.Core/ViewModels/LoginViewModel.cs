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
    public class LoginViewModel : MvxViewModel, ILoginViewModel
    {
        public LoginViewModel(
            ILoginService loginService)
        {
            //Execute CommandFactory here

            Login = new LoginCommand(loginService, this);

            //loginCommand.ViewModel = this;
        }
        
        public string Username { get; set; }
        public string Password { get; set; }

        //public LoginModel Model { get; set; }

        public IMvxCommand Login { get; set; }
        
    }

    public interface IAuthCommand : ICommand
    {
    }

    public interface ILoginCommand : ICommandBuilder
    {
        //ILoginCommand Init(IViewModel<LoginModel> loginViewModel, ILoginService loginService);
    }

    public interface ICommandBuilder : IMvxCommand
    {
        ICommandBuilder BuildWith<T>(T loginService);
    }

    public class AuthTokenModel
    {
    }

    public interface IViewModel<T>
    {
        T Model { get; set; }
    }
}
