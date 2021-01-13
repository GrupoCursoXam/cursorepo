using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using GitXamarin1.Models;

namespace GitXamarin1.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        #region Attributes
        public string email;
        public string password;
        public string firstName;
        public string lastName;
        public string age;
        public string country;

        #endregion

        #region Properties
        private string EmailTxt{
            get { return this.email; }

            set { SetValue(ref this.email, value); }
        }
        private string PasswordTxt
        {
            get { return this.password; }

            set { SetValue(ref this.password, value); }
        }
        private string FirstNameTxt
        {
            get { return this.firstName; }

            set { SetValue(ref this.firstName, value); }
        }
        private string LastNameTxt
        {
            get { return this.lastName; }

            set { SetValue(ref this.lastName, value); }
        }
        private string AgeTxt
        {
            get { return this.age; }

            set { SetValue(ref this.age, value); }
        }
        private string CountryTxt
        {
            get { return this.country; }

            set { SetValue(ref this.country, value); }
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
            if (string.IsNullOrEmpty(this.EmailTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error","Debe ingresar un email","Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.PasswordTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debe ingresar password", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.FirstNameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debe ingresar un nombre", "Aceptar");
                return;
            }

            var user = new Users
            {
                Email = EmailTxt.ToLower(),
                FirsName = EmailTxt.ToLower(),
                LastName = LastNameTxt.ToLower(),
                Age = AgeTxt.ToLower(),
                Country = CountryTxt.ToLower(),
                CreationDate = DateTime.UtcNow.Date
            };

            await App.Database.SaveUserAsync(user);
        }
        #endregion
    }
}
