using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airline_reservation_system
{
    public partial class view_all_flights : Form
    {
        private starting_form obj;
        public view_all_flights(starting_form obj)
        {
            this.obj = obj;
            InitializeComponent();
            ShowFlights();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");

        private void ShowFlights()
        {
            con.Open();
            string Query = "Select * from dbo.Flight";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        //int Key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into dbo.CUSTOMER(FLIGHTID, SSN, NAME, BIRTHDAY)values(@FID, @SSN, @NM, @BD)", con);
                    cmd.Parameters.AddWithValue("@FID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@SSN", textBox2.Text);
                    cmd.Parameters.AddWithValue("@NM", textBox3.Text);
                    cmd.Parameters.AddWithValue("@BD", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("Update dbo.FLIGHT Set AVAILABLE_SEATS=AVAILABLE_SEATS-1 Where FLIGHTID=@FID", con);
                    cmd2.Parameters.AddWithValue("@FID", textBox1.Text);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Ticket added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowFlights();
            }
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_all_flights_Load(object sender, EventArgs e)
        {

        }
    }
}
