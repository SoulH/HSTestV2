using HSTestV2.Interfaces;
using SQLite;
using System;
using Xamarin.Forms;

namespace HSTestV2.Data
{
    public class DbContext : IDisposable
    {
        public SQLiteConnection Db { get; private set; }

        public DbContext()
        {
            var dir = DependencyService.Get<ISQLitePlatform>();
            Db = new SQLiteConnection(dir.GetPath());
        }

        public void Migrate()
        {

        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
