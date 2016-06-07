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

namespace StudentPortalApp.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class LoginViewModel : MvxViewModel, IViewModel<LoginModel>
    {
        public LoginViewModel()
        {
            Login = new LoginCommand(this);
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginModel Model { get; set; }

        public ICommand Login { get; set; }
        public ICommand AuthCommand { get; set; }
    }

    public class AuthTokenModel
    {
    }

    public interface IViewModel<T>
    {
        T Model { get; set; }
    }
}
