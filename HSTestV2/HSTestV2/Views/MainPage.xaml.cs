using HSTestV2.Helpers;
using HSTestV2.Interfaces;
using HSTestV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HSTestV2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainPageMenuItem;
            if (item == null)
                return;

            if (item.Id == 0)
            {
                OnExitAsync(sender, e);
                return;
            };

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }

        private async void OnExitAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var close = await DisplayAlert("Aviso", "¿Seguro quiere salir de la aplicación?", "Sí", "No");

            if (close)
            {
                Settings.IsLoggedIn = string.Empty;
                DependencyService.Get<ICloseApplicationPlatform>()?.Close();
            }
        }
    }
}