using HSTestV2.Models;
using HSTestV2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HSTestV2.ViewModels
{
    class MainPageMasterViewModel : BaseViewModel
    {
        #region Props
        private ObservableCollection<MainPageMenuItem> menuItems;
        public ObservableCollection<MainPageMenuItem> MenuItems {
            get { return menuItems; }
            set { SetProperty(ref menuItems, value); }
        }

        private string user;
        public string User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }
        #endregion

        public MainPageMasterViewModel()
        {
            menuItems = new ObservableCollection<MainPageMenuItem>(new[]
            {
                    new MainPageMenuItem { Id = 1, Title = "Ver Datos", TargetType = typeof(DataPage) },
                    new MainPageMenuItem { Id = 0, Title = "Salir" },
            });
        }
    }
}
