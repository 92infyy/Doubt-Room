namespace LoginPage
{
    partial class Signup
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
            this.TXTuserid = new System.Windows.Forms.TextBox();
            this.LBLuserid = new System.Windows.Forms.Label();
            this.TXTpass = new System.Windows.Forms.TextBox();
            this.LBLpassword = new System.Windows.Forms.Label();
            this.TXTconfirm = new System.Windows.Forms.TextBox();
            this.LBLconfirm = new System.Windows.Forms.Label();
            this.TXTrealname = new System.Windows.Forms.TextBox();
            this.LBLrealname = new System.Windows.Forms.Label();
            this.BTNsignup = new System.Windows.Forms.Button();
            this.LBLmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTuserid
            // 
            this.TXTuserid.Location = new System.Drawing.Point(150, 27);
            this.TXTuserid.Name = "TXTuserid";
            this.TXTuserid.Size = new System.Drawing.Size(100, 22);
            this.TXTuserid.TabIndex = 0;
            // 
            // LBLuserid
            // 
            this.LBLuserid.AutoSize = true;
            this.LBLuserid.Location = new System.Drawing.Point(29, 32);
            this.LBLuserid.Name = "LBLuserid";
            this.LBLuserid.Size = new System.Drawing.Size(53, 17);
            this.LBLuserid.TabIndex = 1;
            this.LBLuserid.Text = "User Id";
            // 
            // TXTpass
            // 
            this.TXTpass.Location = new System.Drawing.Point(150, 67);
            this.TXTpass.Name = "TXTpass";
            this.TXTpass.Size = new System.Drawing.Size(100, 22);
            this.TXTpass.TabIndex = 1;
            // 
            // LBLpassword
            // 
            this.LBLpassword.AutoSize = true;
            this.LBLpassword.Location = new System.Drawing.Point(29, 72);
            this.LBLpassword.Name = "LBLpassword";
            this.LBLpassword.Size = new System.Drawing.Size(69, 17);
            this.LBLpassword.TabIndex = 1;
            this.LBLpassword.Text = "Password";
            // 
            // TXTconfirm
            // 
            this.TXTconfirm.Location = new System.Drawing.Point(150, 106);
            this.TXTconfirm.Name = "TXTconfirm";
            this.TXTconfirm.Size = new System.Drawing.Size(100, 22);
            this.TXTconfirm.TabIndex = 2;
            // 
            // LBLconfirm
            // 
            this.LBLconfirm.AutoSize = true;
            this.LBLconfirm.Location = new System.Drawing.Point(29, 109);
            this.LBLconfirm.Name = "LBLconfirm";
            this.LBLconfirm.Size = new System.Drawing.Size(120, 17);
            this.LBLconfirm.TabIndex = 1;
            this.LBLconfirm.Text = "Confirm pass";
            // 
            // TXTrealname
            // 
            this.TXTrealname.Location = new System.Drawing.Point(150, 143);
            this.TXTrealname.Name = "TXTrealname";
            this.TXTrealname.Size = new System.Drawing.Size(100, 22);
            this.TXTrealname.TabIndex = 3;
            // 
            // LBLrealname
            // 
            this.LBLrealname.AutoSize = true;
            this.LBLrealname.Location = new System.Drawing.Point(29, 148);
            this.LBLrealname.Name = "LBLrealname";
            this.LBLrealname.Size = new System.Drawing.Size(78, 17);
            this.LBLrealname.TabIndex = 1;
            this.LBLrealname.Text = "Real Name";
            // 
            // BTNsignup
            // 
            this.BTNsignup.Location = new System.Drawing.Point(81, 196);
            this.BTNsignup.Name = "BTNsignup";
            this.BTNsignup.Size = new System.Drawing.Size(100, 30);
            this.BTNsignup.TabIndex = 4;
            this.BTNsignup.Text = "Sign up";
            this.BTNsignup.UseVisualStyleBackColor = true;
            this.BTNsignup.Click += new System.EventHandler(this.BTNsignup_Click);
            // 
            // LBLmessage
            // 
            this.LBLmessage.AutoSize = true;
            this.LBLmessage.Location = new System.Drawing.Point(297, 161);
            this.LBLmessage.Name = "LBLmessage";
            this.LBLmessage.Size = new System.Drawing.Size(46, 17);
            this.LBLmessage.TabIndex = 3;
            this.LBLmessage.Text = "label1";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.LBLmessage);
            this.Controls.Add(this.BTNsignup);
            this.Controls.Add(this.LBLrealname);
            this.Controls.Add(this.LBLconfirm);
            this.Controls.Add(this.LBLpassword);
            this.Controls.Add(this.LBLuserid);
            this.Controls.Add(this.TXTrealname);
            this.Controls.Add(this.TXTconfirm);
            this.Controls.Add(this.TXTpass);
            this.Controls.Add(this.TXTuserid);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTuserid;
        private System.Windows.Forms.Label LBLuserid;
        private System.Windows.Forms.TextBox TXTpass;
        private System.Windows.Forms.Label LBLpassword;
        private System.Windows.Forms.TextBox TXTconfirm;
        private System.Windows.Forms.Label LBLconfirm;
        private System.Windows.Forms.TextBox TXTrealname;
        private System.Windows.Forms.Label LBLrealname;
        private System.Windows.Forms.Button BTNsignup;
        public System.Windows.Forms.Label LBLmessage;
    }
}