using Xamarin.Forms;

[assembly: Dependency(typeof(HSTestV2.Droid.Implementations.SQLiteAndroidPlatform))]
namespace HSTestV2.Droid.Implementations
{
    using HSTestV2.Interfaces;
    using System.IO;

    public class SQLiteAndroidPlatform : ISQLitePlatform
    {
        public string GetPath(string dbName = "hstestv2.db3")
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
        }
    }
}