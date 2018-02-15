using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HSTestV2.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        #region commands
        public ICommand RegisterCommand { get; private set; }

        public ICommand ResetCommand { get; private set; }
        #endregion

        #region props
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { SetProperty(ref lastName, value); }
        }

        private string user;
        public string User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { SetProperty(ref phone, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { SetProperty(ref confirmPassword, value); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        private bool show;
        public bool Show
        {
            get { return show; }
            set { SetProperty(ref show, value); }
        }
        #endregion

        public RegisterViewModel()
        {
            RegisterCommand = new Command(Register);
            ResetCommand = new Command(Reset);
            Show = false;
            Message = string.Empty;
            Reset();
        }

        #region methods
        public void Reset()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            User = string.Empty;
            Password = string.Empty;
            ConfirmPassword = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
        }

        public void Register()
        {

        }
        #endregion
    }
}
