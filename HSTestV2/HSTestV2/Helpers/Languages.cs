using HSTestV2.Interfaces;
using HSTestV2.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HSTestV2.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalizePlatform>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalizePlatform>().SetLocale(ci);
        }

        public static string Title { get { return Resource.Title; } }

        public static string Accept { get { return Resource.Accept; } }

        public static string Yes { get { return Resource.Yes; } }

        public static string No { get { return Resource.No; } }

    }

}
