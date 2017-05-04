using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_YassYass_Spring17
{
    public partial class Form1 : Form
    {
        //This is the second form it will show when user clicks on Setting icon
        public Form1()
        {
            InitializeComponent();
            
            //This will default homepage and start page to www.google.com
            //It can be changed too
            defaultHomePage.Text = defaultsSetting.Defaultpage = "http://www.google.com";
        }

        //When okay button clicked it will assign default webpage to the user one assigned or wrote
        private void BTNokay_Click(object sender, EventArgs e)
        {
            
            defaultsSetting.Defaultpage = defaultHomePage.Text;

            this.Close();
            
            
        }
    }

}
