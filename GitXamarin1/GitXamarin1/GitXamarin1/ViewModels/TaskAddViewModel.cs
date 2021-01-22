using GalaSoft.MvvmLight.Command;
using GitXamarin1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GitXamarin1.ViewModels
{
    class TaskAddViewModel : BaseViewModel
    {
        #region Attributes
        private string taskname;
       

        #endregion

        #region Properties
        public string TaskNameTxt
        {
            get { return this.taskname; }

            set { SetValue(ref this.taskname, value); }
        }
       
       
        #endregion

        #region Commands
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
        }
        #endregion

        #region Methods
        private async void RegisterMethod()
        {
            if (string.IsNullOrEmpty(this.TaskNameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debe ingresar una tarea", "Aceptar");
                return;
            }
          

            var todom = new TodoModel
            {
                TaskName = TaskNameTxt.ToLower(),
                TaskDate = DateTime.UtcNow.Date
            };

            await App.Database.SaveTodoAsync(todom);
        }
        #endregion
    }
}
