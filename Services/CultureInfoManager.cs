using PaperRockScissors_MauiGame.Services.Enums;
using PaperRockScissors_MauiGame.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissors_MauiGame.Services
{
    public class CultureInfoManager : ICultureInfoManager
    {
        public string GetCultureInfo() => Preferences.Get("UserLanguage", CultureInfo.GetCultureInfo(CultureInfo.CurrentUICulture.Name).ToString());
        public void SetCultureInfo(Languages culture)
        {
            Preferences.Set("UserLanguage", culture.ToString());
        }
    }
}
