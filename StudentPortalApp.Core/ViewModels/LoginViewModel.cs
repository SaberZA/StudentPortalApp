using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace StudentPortalApp.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class LoginViewModel : MvxViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
}
