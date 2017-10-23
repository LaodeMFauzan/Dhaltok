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

namespace DhalTok
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '•';
        }



        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != " " && tbPassword.Text != " " &&
                tbPhone.Text != " " && tbUname.Text != " ")
            {
                if (cbReg.Checked == true) { 
                try
                {
                    string con = "datasource=localhost; port=3306;  database=dhaltokdb; username =root; password=";
                    MySqlConnection connection = new MySqlConnection(con);

                    //Check for duplicate username
                    MySqlCommand dup = new MySqlCommand("Select * from dhaltokdb.tbl_user where UserName=@username and Email=@email", connection);
                    dup.Parameters.AddWithValue("@username", tbUname.Text);
                    dup.Parameters.AddWithValue("@email", tbEmail.Text);

                    MySqlDataAdapter adapt = new MySqlDataAdapter(dup);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    connection.Close();
                    int count = ds.Tables[0].Rows.Count;

                    //Insert query
                    string insertQuery = "INSERT INTO dhaltokdb.tbl_user(Username,Password,Email,Telepon) VALUES('"
                        + tbUname.Text + "','" + tbPassword.Text + "','" + tbEmail.Text + "'," + tbPhone.Text + ")";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    try
                    {
                        if (count == 0)
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Registration Success");
                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            else
                            {
                                MessageBox.Show("Registration Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or Email already registered");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Field can't be blank");
                }


            }
                else
                {
                    MessageBox.Show("Term and Agreements must be checked");
                }
            }
        }
    }
}
