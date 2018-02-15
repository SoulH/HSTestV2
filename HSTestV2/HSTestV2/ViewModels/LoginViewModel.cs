using HSTestV2.Helpers;
using HSTestV2.Services;
using HSTestV2.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HSTestV2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Commands
        public ICommand LoginCommand { get; private set; }

        public ICommand RegisterCommand { get; private set; }
        #endregion

        #region Properties
        private string user;
        public string User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
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

        private bool rememberMe;
        public bool RememberMe
        {
            get { return rememberMe; }
            set { SetProperty(ref rememberMe, value); }
        }

        private INavigation nav;
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(async () => await NavigationService.PushAsync(new RegisterPage()));
            user = string.Empty;
            password = string.Empty;
            rememberMe = true;
            message = "prueba";
            IsBusy = true;
            show = false;
        }

        public LoginViewModel(INavigation nav)
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(async () => await NavigationService.PushAsync(new RegisterPage()));
            user = string.Empty;
            password = string.Empty;
            rememberMe = true;
            message = "prueba";
            IsBusy = true;
            show = false;
            this.nav = nav;
        }

        #region methods
        public async void Login()
        {
            IsBusy = true;
            Title = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(user.Trim()))
                {
                    if (!string.IsNullOrEmpty(password.Trim()))
                    {
                        //var context = new DbContext();
                        var usr = new { Id = 1, User = "Guest", Password = "12345", Email = "anemailname@example.com" };
                        //context.Users.Where(f => f.Name.Equals(_user) || f.Email.Equals(_user)).FirstOrDefault();

                        if (usr?.Password == password)
                        {
                            Settings.IsLoggedIn = usr.Id;
                            await NavigationService.ChangeToPageAsync(new MainPage());
                        }
                        else
                        {
                            Message = "Usuario o contraseña incorrecta";
                        }
                        IsBusy = false;
                    }
                    else
                    {
                        IsBusy = false;
                        Message = "La contraseña es requerido";
                    }

                }
                else
                {
                    IsBusy = false;
                    Message = "El email es requerido";
                }

            }
            catch (Exception e)
            {
                IsBusy = false;
                await App.Current.MainPage.DisplayAlert("Error de conexión", e.Message, "Ok");
            }
        }
        #endregion
    }
}
