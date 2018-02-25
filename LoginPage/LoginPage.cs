using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace LoginPage
{
    public partial class LoginForm : Form
    {
        List<User> list = new List<User>();
        public LoginForm()
        {
            InitializeComponent();
            TXTpassword.PasswordChar = '•';
                }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://10.1.0.10:8090/");
           
            //HtmlElement btn = doc.GetElementById("");
           //click1.InvokeMember("click");




            //webBrowser1.Document.GetElementById("moreInfoContainer").InvokeMember("click");
            // webBrowser1.Document.GetElementById("overrridelink").InvokeMember("click");








            // HtmlElement txt = webBrowser.Document.GetElementById("msgDiv");
            //txt.SetAttribute("value", TXTusername.Text);
            //HtmlElement tx = webBrowser.Document.GetElementById("usernametxt");
            //tx.SetAttribute("value", TXTpassword.Text);



            label1.Visible = true;
            p1.Visible = true;
            LBLmessage.Text = "";
            Application.DoEvents();
            
           


          DataAccess db = new DataAccess();

          list = db.getUser(TXTusername.Text, TXTpassword.Text);

            if (list.Count==0)
            {
                LBLmessage.ForeColor = Color.Red;
                p1.Visible = false;
                label1.Visible = false;
                
                Application.DoEvents();
                LBLmessage.Text = "Invalid username";
                LBLsignup.Visible = true;

            }
            else


            {
                if( list[0].pass != TXTpassword.Text)
                {

                    LBLmessage.ForeColor = Color.Red;
                   p1.Visible = false;
                    label1.Visible = false;
                    Application.DoEvents();
                    LBLmessage.Text = "Invalid password";
                    
                }
                else
                {
                    label1.Visible = false;
                    Application.DoEvents();
                    LBLmessage.ForeColor = Color.Green;
                    p1.Visible = false;
                    LBLmessage.Text = "Welcome"+ " " + list[0].realName;

                    
                }
            }
        }

        private void LBLsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
        }

        private void BTNsignup_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

     

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {

        

        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BW_DoWork_1(object sender, DoWorkEventArgs e)
        {
            DataAccess db = new DataAccess();

            list = db.getUser(TXTusername.Text, TXTpassword.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
