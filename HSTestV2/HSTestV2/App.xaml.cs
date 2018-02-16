using HSTestV2.Helpers;
using HSTestV2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HSTestV2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //new DbContext().Migrate();
            if (!string.IsNullOrEmpty(Settings.IsLoggedIn))
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage())
                {
                    BarBackgroundColor = Color.FromHex("#FCAC0C")
                };
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
