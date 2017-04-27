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
            homepage();
        }

        //This assigns homepage to the webbrowser and navigates to it when program starts
        private void homepage()
        {
            
           String homepage = UrlBox.Text = "http://www.google.com";
           webBrowser1.Navigate(homepage);
            
        }

        //this method that enters gives address put in URLBOX 
        //to webBrowser widget and navigates to webpage
        private void go2()
        {
            webBrowser1.Navigate(UrlBox.Text);
        }

        private void Progressbar()
        {
            
        }

        #region ButtonsEvents

        //This method is the go back button, it triggers when pressed and goes to previous page
        private void BackClick(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //This button event goes back to previous page of previous page
        private void BTNnext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        //if key "Enter" Pressed it will trigger event here
        private void UrlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (Char)ConsoleKey.Enter)
            {
                go2();
            }
        }

        //This is event for navigation button that used if user doesnt 
        //want to press enter when address is entered
        private void BTNgo_Click(object sender, EventArgs e)
        {
            go2();
        }

        //When Home button clicked it will go to the Home page
        private void BTNHome_Click(object sender, EventArgs e)
        {
            homepage();
        }

        #endregion

    }
}
