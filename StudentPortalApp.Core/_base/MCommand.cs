using System;
using System.Linq;
using MvvmCross.Platform;
using StudentPortalApp.Core.ViewModels;

namespace StudentPortalApp.Core.Commands
{
    public abstract class MCommand : IMCommand
    {
        public void RaiseCanExecuteChanged()
        {

        }

        public virtual void Execute()
        {
            Execute(null);
        }
        public abstract void Execute(object parameter);

        public abstract bool CanExecute();
        public virtual bool CanExecute(object parameter)
        {
            return this.CanExecute();
        }

        public event EventHandler CanExecuteChanged;

        public ICommandBuilder BuildWith<T>(T item)
        {
            var command = this as ICommandBuilder;
            var propertyInfo = command.GetType().GetProperties().First(p => p.PropertyType == typeof(T));
            propertyInfo?.SetValue(command,item);
            return command;
        }
    }
}