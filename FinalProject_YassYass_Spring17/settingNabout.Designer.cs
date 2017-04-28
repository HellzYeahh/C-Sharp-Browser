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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultHomePage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNokay = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // defaultHomePage
            // 
            this.defaultHomePage.Location = new System.Drawing.Point(132, 46);
            this.defaultHomePage.Name = "defaultHomePage";
            this.defaultHomePage.Size = new System.Drawing.Size(238, 20);
            this.defaultHomePage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default HomePage/StartPage";
            // 
            // BTNokay
            // 
            this.BTNokay.Location = new System.Drawing.Point(213, 390);
            this.BTNokay.Name = "BTNokay";
            this.BTNokay.Size = new System.Drawing.Size(75, 23);
            this.BTNokay.TabIndex = 2;
            this.BTNokay.Text = "Okay";
            this.BTNokay.UseVisualStyleBackColor = true;
            this.BTNokay.Click += new System.EventHandler(this.BTNokay_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(67, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 280);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 425);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BTNokay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultHomePage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox defaultHomePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNokay;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}