using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.enums;

namespace WpfApp1.resources
{
    public static class MainWindowResources
    {
        public static string GetMainWindowTitle()
        {
            return GeenralConstants.APPNAME + " by " + GeenralConstants.AUTHOR + ". DevStatus: " + GeenralConstants.APP_DEVELOPING_STATUS;
        }
    }
}
