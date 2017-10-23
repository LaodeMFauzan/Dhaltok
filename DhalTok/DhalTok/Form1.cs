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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbCode.Text = Home.travel_code;
            lbFrom.Text = Home.from;
            lbTo.Text = Home.to;
            lbTime.Text = Home.time;
            lbNums.Text = Home.number_of_books;
            label7.Text = Convert.ToString(Home.total_price);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
