using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_YassYass_Spring17
{
    static class defaultsSetting
    {
        private static string defaultpage;
        public static string Defaultpage
        {
            //get and set default webpage
            get
            {
                return defaultpage;
            }
            set { defaultpage = value; }
        }
    }
}
