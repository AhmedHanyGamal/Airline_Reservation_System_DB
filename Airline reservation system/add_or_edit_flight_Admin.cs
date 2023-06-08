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
    public partial class add_or_edit_flight_Admin : Form
    {
        main_screen_Admin obj;
        public add_or_edit_flight_Admin(main_screen_Admin obj)
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || dateTimePicker1.Value == null)
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into dbo.Flight(FLIGHTID, DATE, SOURCE, DESTINATION, FLIGHT_CLASS, AVAILABLE_SEATS)values(@FID, @DT, @SRC, @DEST, @FC, @AS)", con);
                    cmd.Parameters.AddWithValue("@FID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DT", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@SRC", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DEST", textBox3.Text);
                    cmd.Parameters.AddWithValue("@FC", textBox4.Text);
                    cmd.Parameters.AddWithValue("@AS", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowFlights();
            }
        }

        private void add_or_edit_flight_Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.Flight where FLIGHTID='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.Flight where FLIGHTID='" + textBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Cancelled");
                }
                else
                {
                    MessageBox.Show("Flight Doesn't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            ShowFlights();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Update dbo.FLIGHT Set FLIGHTID=@FID,DATE=@DT,SOURCE=@SRC,DESTINATION=@DEST,FLIGHT_CLASS=@FC,AVAILABLE_SEATS=@AVAILS Where FLIGHTID=@FID", con);
                    cmd.Parameters.AddWithValue("@FID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DT", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@SRC", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DEST", textBox3.Text);
                    cmd.Parameters.AddWithValue("@FC", textBox4.Text);
                    cmd.Parameters.AddWithValue("@AVAILS", textBox5.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Flight Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Flight Update FAILED");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowFlights();
            }
        }
    }
}
