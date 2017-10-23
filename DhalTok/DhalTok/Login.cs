using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DhalTok
{
    
    public partial class Login : Form
    {
        Register frm = new Register();
        Home home = new Home();

        //Placeholder  code
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32
           SendMessage(
                           IntPtr hWnd,
                           int msg,
                           int wParam,
                           [MarshalAs(UnmanagedType.LPWStr)]string lParam
                       );
        private const int EM_SETCUEBANNER = 0x1501;

        public static string username;
        public static string password;
        public static string email;
        public static string phone;

        public Login()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            SendMessage(tbUname.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(tbPassword.Handle, EM_SETCUEBANNER, 0, "Password");

            //Hover Code
            btRegister.MouseEnter += OnMouseEnterButton1;
            btRegister.MouseLeave += OnMouseLeaveButton1;
            btLogin.MouseEnter += OnMouseEnterButton2;
            btLogin.MouseLeave += OnMouseLeaveButton2;
        }

        //Hover Code
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            btRegister.BackColor = Color.DeepSkyBlue; // or Color.Red or whatever you want
             }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            btRegister.BackColor = Color.RoyalBlue;
         }

        private void OnMouseEnterButton2(object sender, EventArgs e)
        {
             btLogin.BackColor = Color.DeepSkyBlue; // or Color.Red or whatever you want
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e)
        {
           btLogin.BackColor = Color.LimeGreen;
        }

        //Login backend
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUname.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please enter UserName and Password");
                return;
            }

            try
            {
                string con = "datasource=localhost; port=3306;  database=dhaltokdb; username =root; password=";
                MySqlConnection connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from tbl_user where UserName=@username and Password=@password", connection);
                cmd.Parameters.AddWithValue("@username", tbUname.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);

                //connection.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connection.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    username = tbUname.Text.ToString();
                    password = tbPassword.Text.ToString();
                    email = ds.Tables[0].Rows[0][3].ToString();
                    phone = ds.Tables[0].Rows[0][4].ToString();

                    MessageBox.Show("Login Success!");
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password or Username!");
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
