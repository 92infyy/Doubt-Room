namespace LoginPage
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginlabel = new System.Windows.Forms.Label();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.TXTpassword = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.LBLmessage = new System.Windows.Forms.Label();
            this.LBLsignup = new System.Windows.Forms.LinkLabel();
            this.BTNsignup = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Location = new System.Drawing.Point(46, 45);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(73, 17);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Username";
            // 
            // BTNlogin
            // 
            this.BTNlogin.Location = new System.Drawing.Point(34, 210);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(85, 35);
            this.BTNlogin.TabIndex = 3;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = true;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // TXTusername
            // 
            this.TXTusername.Location = new System.Drawing.Point(145, 42);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(100, 22);
            this.TXTusername.TabIndex = 1;
            // 
            // TXTpassword
            // 
            this.TXTpassword.Location = new System.Drawing.Point(145, 83);
            this.TXTpassword.Name = "TXTpassword";
            this.TXTpassword.Size = new System.Drawing.Size(100, 22);
            this.TXTpassword.TabIndex = 2;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(46, 86);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(69, 17);
            this.passwordlabel.TabIndex = 0;
            this.passwordlabel.Text = "Password";
            // 
            // LBLmessage
            // 
            this.LBLmessage.AutoSize = true;
            this.LBLmessage.Location = new System.Drawing.Point(86, 134);
            this.LBLmessage.Name = "LBLmessage";
            this.LBLmessage.Size = new System.Drawing.Size(12, 17);
            this.LBLmessage.TabIndex = 3;
            this.LBLmessage.Text = " ";
            // 
            // LBLsignup
            // 
            this.LBLsignup.AutoSize = true;
            this.LBLsignup.Location = new System.Drawing.Point(62, 179);
            this.LBLsignup.Name = "LBLsignup";
            this.LBLsignup.Size = new System.Drawing.Size(160, 17);
            this.LBLsignup.TabIndex = 4;
            this.LBLsignup.TabStop = true;
            this.LBLsignup.Text = "Do you want to sign up?";
            this.LBLsignup.Visible = false;
            this.LBLsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBLsignup_LinkClicked);
            // 
            // BTNsignup
            // 
            this.BTNsignup.Location = new System.Drawing.Point(145, 210);
            this.BTNsignup.Name = "BTNsignup";
            this.BTNsignup.Size = new System.Drawing.Size(85, 35);
            this.BTNsignup.TabIndex = 6;
            this.BTNsignup.Text = "Sign Up";
            this.BTNsignup.UseVisualStyleBackColor = true;
            this.BTNsignup.Click += new System.EventHandler(this.BTNsignup_Click);
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(104, 87);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(108, 117);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 7;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            this.p1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "loading...";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BW
            // 
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNsignup);
            this.Controls.Add(this.LBLsignup);
            this.Controls.Add(this.LBLmessage);
            this.Controls.Add(this.TXTpassword);
            this.Controls.Add(this.TXTusername);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.p1);
            this.Name = "LoginForm";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button BTNlogin;
        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.TextBox TXTpassword;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label LBLmessage;
        private System.Windows.Forms.LinkLabel LBLsignup;
        private System.Windows.Forms.Button BTNsignup;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker BW;
    }
}

