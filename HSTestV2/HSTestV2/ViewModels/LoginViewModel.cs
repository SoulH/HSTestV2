using HSTestV2.Helpers;
using HSTestV2.Services;
using HSTestV2.Views;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HSTestV2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Commands
        [JsonIgnore]
        public ICommand LoginCommand { get; private set; }
        
        [JsonIgnore]
        public ICommand RegisterCommand { get; private set; }
        #endregion

        #region Properties
        private string user;
        //[JsonProperty(PropertyName = "user")]
        public string User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }

        private string password;
        //[JsonProperty(PropertyName = "password")]
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private string message;
        [JsonIgnore]
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        private bool show;
        [JsonIgnore]
        public bool Show
        {
            get { return show; }
            set { SetProperty(ref show, value); }
        }

        private bool rememberMe;
        [JsonIgnore]
        public bool RememberMe
        {
            get { return rememberMe; }
            set { SetProperty(ref rememberMe, value); }
        }
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(async () => await NavigationService.PushAsync(new RegisterPage()));
            user = string.Empty;
            password = string.Empty;
            rememberMe = true;
            message = "prueba";
            IsBusy = true;
            show = false;
        }

        #region methods
        public async Task Login()
        {
            IsBusy = true;
            Title = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(user.Trim()))
                {
                    if (!string.IsNullOrEmpty(password.Trim()))
                    {
                        var auth = await ApiService.Auth(this);

                        if (auth.Success)
                        {
                            Settings.IsLoggedIn = (rememberMe)? auth.Token : string.Empty;
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
