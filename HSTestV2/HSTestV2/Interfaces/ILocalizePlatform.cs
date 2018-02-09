using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HSTestV2.Interfaces
{
    public interface ILocalizePlatform
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
