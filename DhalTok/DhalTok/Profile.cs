using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DhalTok
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lbUsername.Text = Login.username;
            lbUsername2.Text = Login.username;
            lbPassword.Text = Login.password;
            lbPhone.Text = Login.phone;
            lbEmail.Text = Login.email;
        }

        private void lbUsername2_Click(object sender, EventArgs e)
        {

        }
    }
}
