using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void BTNsignup_Click(object sender, EventArgs e)
        {
            User user1 = new User();


                user1.pass = TXTpass.Text;
            user1.realName = TXTrealname.Text;
            user1.userName = TXTuserid.Text;

            DataAccess db = new DataAccess();
            db.insertUser(user1);

          

        }
    }
}
