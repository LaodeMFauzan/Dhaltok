using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;


namespace DhalTok
{
    public partial class Home : Form
    {
        
        string con = "datasource=localhost; port=3306;  database=dhaltokdb; username =root; password=";
        public static string username;
        public static string password;

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

        public static string travel_code;
        public static string from;
        public static string to;
        public static string time;
        public static string number_of_books;
        public static int total_price;
        public Home()
        {
            InitializeComponent();
            SendMessage(tbCode.Handle, EM_SETCUEBANNER, 0, "Enter Route Code");
            SendMessage(tbNumOrder.Handle, EM_SETCUEBANNER, 0, "Number of Books");

            //The code below is for query of available seat
        //    lbSeatLM.Text = 40.ToString();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        //String query = "update tbl_perjalanan set seat_available=" + seat_sisa;
        private void btOrder_Click(object sender, EventArgs e)
        {   
            
            tabControl1.SelectedIndex= (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
            
            if (tbNumOrder.Text == "1")
            {
                p1.Visible = true;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
            }
            else if (tbNumOrder.Text == "2")
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = false;
                p4.Visible = false;
            }
            else if (tbNumOrder.Text == "3")
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = false;
            }
            else if (tbNumOrder.Text == "4")
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = true;
            }

            travel_code = tbCode.Text.ToString();
            number_of_books = tbNumOrder.Text.ToString();
        }

        private void tbProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
        }

        private void tpPassenger_Click(object sender, EventArgs e)
        {
            if (tbNumOrder.Text == "1")
            {
                p1.Visible = true;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
            }
            else if (tbNumOrder.Text == "2")
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = false;
                p4.Visible = false;
            }
            else if (tbNumOrder.Text == "3")
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = false;
            }
            else if (tbNumOrder.Text == "4")
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                           tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;


            if (tbNumOrder.Text == "1")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else if (tbNumOrder.Text == "2")
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else if (tbNumOrder.Text == "3")
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = false;
            }
            else if (tbNumOrder.Text == "4")
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
            }

            textBox9.Text = textBox2.Text;
            textBox10.Text = textBox1.Text;
            textBox11.Text = textBox4.Text;
            textBox12.Text = textBox3.Text;
            textBox13.Text = textBox6.Text;
            textBox14.Text = textBox5.Text;
            textBox15.Text = textBox8.Text;
            textBox16.Text = textBox7.Text;
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand cmdd = new MySqlCommand("Select * from tbl_perjalanan where travel_code=@kode", connection);
            cmdd.Parameters.AddWithValue("@kode", tbCode.Text);
            MySqlDataAdapter SDAa = new MySqlDataAdapter(cmdd);
            DataTable dtt = new DataTable();
            SDAa.Fill(dtt);
            dataGridView2.DataSource = dtt;
            connection.Close();
            dataGridView2.Visible = true;

            //Invoice Data
            MySqlDataAdapter invoice = new MySqlDataAdapter(cmdd);
            DataSet data_invoice = new DataSet();
            invoice.Fill(data_invoice);
            from = data_invoice.Tables[0].Rows[0][1].ToString();
            to = data_invoice.Tables[0].Rows[0][2].ToString();
            time = data_invoice.Tables[0].Rows[0][3].ToString();

            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView2.GridColor = Color.Silver;

            MySqlCommand total = new MySqlCommand("Select price from tbl_perjalanan where travel_code=@kode", connection);
            total.Parameters.AddWithValue("@kode", tbCode.Text);
            MySqlDataAdapter adapts = new MySqlDataAdapter(total);
            DataSet ass = new DataSet();
            adapts.Fill(ass);
            String price = (ass.Tables[0].Rows[0][0].ToString());
            int qty = Convert.ToInt16(tbNumOrder.Text);
             total_price = (Convert.ToInt32(price)*qty);
            label23.Text = "Total Harga: "+ total_price.ToString();
            label23.Visible = true;
         
           
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNumOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }


       

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            String query = "Select * from tbl_perjalanan";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            dataGridView1.Visible = true;
            tbCode.Visible = true;
            tbNumOrder.Visible = true;
            btOrder.Visible = true;
            button4.Hide();
            
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.GridColor = Color.Silver;
        }

        private void tpTransac_Click(object sender, EventArgs e)
        {

        }

        private void p4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "datasource=localhost; port=3306;  database=dhaltokdb; username =root; password=";
                MySqlConnection connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmds = new MySqlCommand("Select seat_available from tbl_perjalanan where travel_code=@kode", connection);
                cmds.Parameters.AddWithValue("@kode", tbCode.Text);
                

                //connection.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmds);
                DataSet dss = new DataSet();
                adapt.Fill(dss);
                int sisa_seat = Convert.ToInt16(dss.Tables[0].Rows[0][0].ToString());

                MySqlCommand cmdd = new MySqlCommand("update tbl_perjalanan set seat_available=@sisa where travel_code=@kode", connection);
                cmdd.Parameters.AddWithValue("@kode", tbCode.Text);
                cmdd.Parameters.AddWithValue("@sisa", (sisa_seat-Convert.ToInt16(tbNumOrder.Text)));
                MySqlDataAdapter adaptt = new MySqlDataAdapter(cmdd);
                DataSet dsss = new DataSet();
                adaptt.Fill(dsss);
                MessageBox.Show("Book Sukses");
                
                connection.Close();
                Invoice frm = new Invoice();
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
