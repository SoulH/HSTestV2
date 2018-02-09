using System;
using System.Collections.Generic;
using System.Text;

namespace HSTestV2.Interfaces
{
    public interface ISQLitePlatform
    {
        string GetPath(string dbName = "hstestv2.db3");
    }
}
