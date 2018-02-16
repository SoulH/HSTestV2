using Plugin.Connectivity;
using System.Threading.Tasks;

namespace HSTestV2.Services
{
    public class InternetService
    {
        public static bool CheckConnection()
        {
            return CrossConnectivity.Current.IsConnected;
        }

        public static async Task<bool> TestConnection(string url)
        {
            return await CrossConnectivity.Current.IsReachable(url);
        }
    }
}
