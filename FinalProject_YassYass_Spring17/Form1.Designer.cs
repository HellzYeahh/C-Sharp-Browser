namespace FinalProject_YassYass_Spring17
{
    partial class Form1
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
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNnext = new System.Windows.Forms.Button();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BTNgo = new System.Windows.Forms.Button();
            this.BTNHome = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNBack
            // 
            this.BTNBack.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.back;
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNBack.FlatAppearance.BorderSize = 0;
            this.BTNBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBack.Location = new System.Drawing.Point(0, -11);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(73, 62);
            this.BTNBack.TabIndex = 0;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BackClick);
            // 
            // BTNnext
            // 
            this.BTNnext.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.forward;
            this.BTNnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNnext.FlatAppearance.BorderSize = 0;
            this.BTNnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNnext.Location = new System.Drawing.Point(137, -16);
            this.BTNnext.Name = "BTNnext";
            this.BTNnext.Size = new System.Drawing.Size(75, 73);
            this.BTNnext.TabIndex = 1;
            this.BTNnext.UseVisualStyleBackColor = true;
            this.BTNnext.Click += new System.EventHandler(this.BTNnext_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(218, 11);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(741, 20);
            this.UrlBox.TabIndex = 2;
            this.UrlBox.Text = "http://";
            this.UrlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrlBox_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
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
            // 
            // BTNgo
            // 
            this.BTNgo.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.go;
            this.BTNgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNgo.FlatAppearance.BorderSize = 0;
            this.BTNgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNgo.Location = new System.Drawing.Point(980, -3);
            this.BTNgo.Name = "BTNgo";
            this.BTNgo.Size = new System.Drawing.Size(47, 42);
            this.BTNgo.TabIndex = 7;
            this.BTNgo.UseVisualStyleBackColor = true;
            this.BTNgo.Click += new System.EventHandler(this.BTNgo_Click);
            // 
            // BTNHome
            // 
            this.BTNHome.BackgroundImage = global::FinalProject_YassYass_Spring17.Properties.Resources.home;
            this.BTNHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNHome.FlatAppearance.BorderSize = 0;
            this.BTNHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHome.Location = new System.Drawing.Point(81, 1);
            this.BTNHome.Name = "BTNHome";
            this.BTNHome.Size = new System.Drawing.Size(50, 37);
            this.BTNHome.TabIndex = 8;
            this.BTNHome.UseVisualStyleBackColor = false;
            this.BTNHome.Click += new System.EventHandler(this.BTNHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 753);
            this.Controls.Add(this.BTNHome);
            this.Controls.Add(this.BTNgo);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.BTNnext);
            this.Controls.Add(this.BTNBack);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

