using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_YassYass_Spring17
{
    class defaultsSetting
    {
        private string defaultpage;
        public string Defaultpage
        {
            get
            {
                return defaultpage = "www.google.com";
            }
            set { defaultpage = value; }
        }
    }
}
