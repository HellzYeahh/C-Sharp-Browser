﻿using System;
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
        defaultsSetting dflt = new defaultsSetting();
        public Form1()
        {
            InitializeComponent();
            
            defaultHomePage.Text = dflt.Defaultpage = "http://www.google.com";
        }

        private void BTNokay_Click(object sender, EventArgs e)
        {
            dflt.Defaultpage = defaultHomePage.Text;

            this.Close();
            
            
        }
    }

}
