using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FinalProject_YassYass_Spring17
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
            
        }
        

        #region Defaults
        
        //This method assigns homepage to the webbrowser and navigates to it when program starts or method called
        private void homepage()
        {

            
           String homepage = UrlBox.Text = (defaultsSetting.Defaultpage);
           webBrowser1.Navigate(homepage);
            
        }

        // It is a method when called it will navigate to that page and change status of the progress bar to loading
        private void go2()
        {
            toolStripLabel1.Text = "Loading";
            webBrowser1.Navigate(UrlBox.Text);
        }

        private void Progressbar()
        {
            
        }
        //This will load or default anything programmed when the application starts
        private void Form1_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(defaultsSetting.Defaultpage = "http://www.google.com");
            UrlBox.Text = defaultsSetting.Defaultpage;

        }

        #endregion


        #region Events

        //This method is the go back button, it triggers when clicked it will go back to previous page
        private void BackClick(object sender, EventArgs e)
        {
            
            webBrowser1.GoBack();
            
        }

  
        //This Forward button is clicked webBrowser widget will go back to previous page of the previous page
        private void BTNnext_Click(object sender, EventArgs e)
        {
           
            webBrowser1.GoForward();
            

        }

        // This method will look for Key pressed on the URLbox widget and do even with it
        //For example if "Eneter" key is pressed it will navigate to that page
        private void UrlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (Char)ConsoleKey.Enter)
            {
                go2();
            }
        }

        //This is navigation button instead of pressing "Enter" 
        //You click Navigate button and it will go to that page
        private void BTNgo_Click(object sender, EventArgs e)
        {
            go2();
        }

        //When Home button clicked it will navigate to the the Home page
        private void BTNHome_Click(object sender, EventArgs e)
        {
            homepage();
        }

        //It will refresh the page when refresh button is clicked, basically navigating to the same page again
        private void BTNrefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }


        //This will display and track web page progress of loading and will display it on the progress bar object/widget.
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 & e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                toolStripLabel1.Text = "Loading";
            }

            else if(e.CurrentProgress > 100 & e.MaximumProgress > 100)
            {
                toolStripLabel1.Text = "Loading...";
            }
        }

        //This method listens to the webrowser object when page done loading it will trigger events
        //For example when webpage done loading set text to something or progress bar status
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripLabel1.Text = "Finished";
            UrlBox.Text = webBrowser1.Url.AbsoluteUri;
        }

        //Easter Egg
        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            foreach (HtmlElement image in webBrowser1.Document.Images)
            {
                image.SetAttribute("src", "https://s-media-cache-ak0.pinimg.com/originals/6e/d7/b0/6ed7b0842f02db2f93018561c1c55d9c.png");
            }
        }

        private void BTNsetting_Click(object sender, EventArgs e)
        {
            Form1 frmSetting = new Form1();

            frmSetting.Show();


        }

        #endregion


    }
}
