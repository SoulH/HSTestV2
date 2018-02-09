using Xamarin.Forms;

[assembly: Dependency(typeof(HSTestV2.iOS.Implementations.SQLiteiOSPlatform))]
namespace HSTestV2.iOS.Implementations
{
    using System;
    using HSTestV2.Interfaces;

    public class SQLiteiOSPlatform : ISQLitePlatform
    {
        private string directoryDB;

        public string GetPath(string dbName = "hstestv2.db3")
        {
            if (string.IsNullOrEmpty(directoryDB))
            {
                var directory = System.Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                directoryDB = System.IO.Path.Combine(directory, "..", "Library");
            }

            return directoryDB;
        }
    }
}