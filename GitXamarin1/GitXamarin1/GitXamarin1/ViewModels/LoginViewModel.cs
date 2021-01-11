using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;
using Application = Xamarin.Forms.Application;

namespace GitXamarin1.ViewModels 
{
    //Class for binding
    class LoginViewModel : BaseViewModel
    {
        #region Attributes
        public string email;
        public string password;
        #endregion

        #region Properties
        private string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        private string PaswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
            set
            {

            }
        }

       
        #endregion

        #region Methods
         private void Login()
        {
            if(EmailTxt.ToString() == "aldo@gmail.com" && PaswordTxt.ToString() == "pamela")
            {
                Application.Current.MainPage.DisplayAlert("Correcto","Logrado", "ok");

            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Incorrecto", "No fue logrado", "ok");
            }
        }
        #endregion

        #region Constructor

        #endregion

    }
}
