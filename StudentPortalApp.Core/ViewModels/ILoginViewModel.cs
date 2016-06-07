using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace StudentPortalApp.Core.ViewModels
{
    public interface ILoginViewModel
    {
        string Username { get; set; }
        string Password { get; set; }

        IMvxCommand Login { get; set; }
    }
}