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
        public Form1()
        {
            InitializeComponent();
        }

        private void starter()
        {
            
        }

        private void BackClick(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void BTNnext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void UrlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if key "Enter" Pressed it will trigger event here
            if (e.KeyChar == (Char) ConsoleKey.Enter)
            {
                webBrowser1.Navigate(UrlBox.Text);
            }
        }

        private void BTNgo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(UrlBox.Text);
        }

        private void BTNHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
