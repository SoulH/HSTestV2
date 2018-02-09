using System.Threading.Tasks;
using Xamarin.Forms;

namespace HSTestV2.Services
{
    class NavigationService
    {
        public static async Task ChangeToPageAsync(Page page)
        {
            var nav = App.Current.MainPage.Navigation;
            var count = nav.NavigationStack.Count;
            await nav.PushAsync(page);
            for (var i = 0; i < count; i++)
            {
                var p = nav.NavigationStack[i];
                nav.RemovePage(p);
            }
        }

        public static async Task PushAsync(Page page)
        {
            var nav = App.Current.MainPage.Navigation;
            await nav.PushAsync(page);
        }

        public static async Task PushModalAsync(Page page)
        {
            var nav = App.Current.MainPage.Navigation;
            await nav.PushModalAsync(page);
        }

        public static async Task PopAsync()
        {
            var nav = App.Current.MainPage.Navigation;
            await nav.PopAsync();
        }

        public static async Task PopModalAsync()
        {
            var nav = App.Current.MainPage.Navigation;
            await nav.PopModalAsync();
        }

        public static void RemovePage(Page page)
        {
            var nav = App.Current.MainPage.Navigation;
            nav.RemovePage(page);
        }

        public static void RemovePage(int index)
        {
            var nav = App.Current.MainPage.Navigation;
            if ((index < 0) || (index > nav.NavigationStack.Count)) return;
            var page = nav.NavigationStack[index];
            nav.RemovePage(page);
        }

        public static void InsertPageBefore(Page page, Page before)
        {
            var nav = App.Current.MainPage.Navigation;
            nav.InsertPageBefore(page, before);
        }

        public static void InsertPage(Page page, int pos)
        {
            var nav = App.Current.MainPage.Navigation;
            if ((pos < 1) || (pos > nav.NavigationStack.Count)) return;
            var before = nav.NavigationStack[pos];
            nav.InsertPageBefore(page, before);
        }

        public static async Task PopToRootAsync()
        {
            var nav = App.Current.MainPage.Navigation;
            await nav.PopToRootAsync();
        }

        public static int Count()
        {
            var nav = App.Current.MainPage.Navigation;
            return nav.NavigationStack.Count;
        }
    }
}
