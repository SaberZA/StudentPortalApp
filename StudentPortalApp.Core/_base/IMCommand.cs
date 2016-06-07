using System;
using MvvmCross.Core.ViewModels;

namespace StudentPortalApp.Core.Commands
{
    public interface IMCommand : IMvxCommand
    {
        new void RaiseCanExecuteChanged();

        new void Execute();
        new void Execute(object parameter);

        new bool CanExecute();
        new bool CanExecute(object parameter);

        new event EventHandler CanExecuteChanged;
    }
}