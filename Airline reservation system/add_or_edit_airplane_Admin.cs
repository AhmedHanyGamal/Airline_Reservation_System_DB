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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_reservation_system
{
    public partial class add_or_edit_airplane_Admin : Form
    {
        main_screen_Admin obj;
        public add_or_edit_airplane_Admin(main_screen_Admin obj)
        {
            this.obj = obj;
            InitializeComponent();
            ShowPlanes();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void ShowPlanes()
        {
            con.Open();
            string Query = "Select * from dbo.AIRCRAFT";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into dbo.AIRCRAFT(AIRCRAFT_ID, MODEL)values(@ID, @MD)", con);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@MD", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Plane added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowPlanes();
            }
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        //int Key = 0;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.AIRCRAFT where AIRCRAFT_ID='" + textBox1.Text + "' and MODEL='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.AIRCRAFT where AIRCRAFT_ID='" + textBox1.Text + "' and MODEL='" + textBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("AirCraft Deleted from Database");
                }
                else
                {
                    MessageBox.Show("AirCraft Doesn't exist in Database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            ShowPlanes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Update dbo.AIRCRAFT Set AIRCRAFT_ID=@AID,MODEL=@MD Where AIRCRAFT_ID=@AID", con);
                    cmd.Parameters.AddWithValue("@AID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@MD", textBox2.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Ticket Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Ticket Update FAILED");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowPlanes();
            }
        }
    }
}