using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airline_reservation_system
{
    public partial class customer_signup : Form
    {
        public customer_signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Username and Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.CUSTOMER where NAME='" + textBox1.Text + "' and SSN='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) >= 1)
                {
                    main_screen_Customer obj = new main_screen_Customer();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong UserName Or Password");
                }
                con.Close();

            }
        }
    }
}
