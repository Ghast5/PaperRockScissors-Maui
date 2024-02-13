using PaperRockScissors_MauiGame.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissors_MauiGame.Services.Interfaces
{
    public interface ICultureInfoManager
    {
        string GetCultureInfo();
        void SetCultureInfo(Languages culture);
    }
}
