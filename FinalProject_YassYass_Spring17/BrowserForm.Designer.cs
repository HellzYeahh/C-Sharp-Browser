namespace FinalProject_YassYass_Spring17
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BTNsetting = new System.Windows.Forms.Button();
            this.BTNrefresh = new System.Windows.Forms.Button();
            this.BTNHome = new System.Windows.Forms.Button();
            this.BTNgo = new System.Windows.Forms.Button();
            this.BTNnext = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBox.Location = new System.Drawing.Point(157, 2);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(809, 29);
            this.UrlBox.TabIndex = 2;
            this.UrlBox.Text = "http://";
            this.UrlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrlBox_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 728);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1166, 686);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // BTNsetting
            // 
            this.BTNsetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNsetting.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.setting;
            this.BTNsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNsetting.FlatAppearance.BorderSize = 0;
            this.BTNsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNsetting.Location = new System.Drawing.Point(1055, 0);
            this.BTNsetting.Name = "BTNsetting";
            this.BTNsetting.Size = new System.Drawing.Size(33, 35);
            this.BTNsetting.TabIndex = 10;
            this.BTNsetting.UseVisualStyleBackColor = true;
            this.BTNsetting.Click += new System.EventHandler(this.BTNsetting_Click);
            // 
            // BTNrefresh
            // 
            this.BTNrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNrefresh.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.refresh;
            this.BTNrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNrefresh.FlatAppearance.BorderSize = 0;
            this.BTNrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNrefresh.Location = new System.Drawing.Point(1014, 1);
            this.BTNrefresh.Name = "BTNrefresh";
            this.BTNrefresh.Size = new System.Drawing.Size(35, 34);
            this.BTNrefresh.TabIndex = 9;
            this.BTNrefresh.UseVisualStyleBackColor = true;
            this.BTNrefresh.Click += new System.EventHandler(this.BTNrefresh_Click);
            // 
            // BTNHome
            // 
            this.BTNHome.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.home1;
            this.BTNHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNHome.FlatAppearance.BorderSize = 0;
            this.BTNHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHome.Location = new System.Drawing.Point(58, 2);
            this.BTNHome.Name = "BTNHome";
            this.BTNHome.Size = new System.Drawing.Size(41, 32);
            this.BTNHome.TabIndex = 8;
            this.BTNHome.UseVisualStyleBackColor = false;
            this.BTNHome.Click += new System.EventHandler(this.BTNHome_Click);
            // 
            // BTNgo
            // 
            this.BTNgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNgo.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.go1;
            this.BTNgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNgo.FlatAppearance.BorderSize = 0;
            this.BTNgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNgo.Location = new System.Drawing.Point(972, 0);
            this.BTNgo.Name = "BTNgo";
            this.BTNgo.Size = new System.Drawing.Size(36, 35);
            this.BTNgo.TabIndex = 7;
            this.BTNgo.UseVisualStyleBackColor = true;
            this.BTNgo.Click += new System.EventHandler(this.BTNgo_Click);
            // 
            // BTNnext
            // 
            this.BTNnext.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.forward1;
            this.BTNnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNnext.FlatAppearance.BorderSize = 0;
            this.BTNnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNnext.Location = new System.Drawing.Point(105, -4);
            this.BTNnext.Name = "BTNnext";
            this.BTNnext.Size = new System.Drawing.Size(46, 40);
            this.BTNnext.TabIndex = 1;
            this.BTNnext.UseVisualStyleBackColor = true;
            this.BTNnext.Click += new System.EventHandler(this.BTNnext_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.back1;
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNBack.FlatAppearance.BorderSize = 0;
            this.BTNBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBack.Location = new System.Drawing.Point(12, -2);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(40, 40);
            this.BTNBack.TabIndex = 0;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BackClick);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 753);
            this.Controls.Add(this.BTNsetting);
            this.Controls.Add(this.BTNrefresh);
            this.Controls.Add(this.BTNHome);
            this.Controls.Add(this.BTNgo);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.BTNnext);
            this.Controls.Add(this.BTNBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserForm";
            this.Text = "Simple Browser by Yass Yass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Button BTNnext;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BTNgo;
        private System.Windows.Forms.Button BTNHome;
        private System.Windows.Forms.Button BTNrefresh;
        private System.Windows.Forms.Button BTNsetting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

