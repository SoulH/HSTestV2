using HSTestV2.Helpers;
using System.Threading.Tasks;

namespace HSTestV2.Services
{
    public class DialogService
    {
        public static async Task ShowMessage(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, Languages.Accept);
        }

        public static async Task<bool> ShowConfirm(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, Languages.Yes, Languages.No);
        }
    }
}
