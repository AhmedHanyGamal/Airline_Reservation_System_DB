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
    public partial class manage_tickets_Admin : Form
    {
        main_screen_Admin obj;
        public manage_tickets_Admin(main_screen_Admin obj)
        {
            this.obj = obj;
            InitializeComponent();
            ShowTickets();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");
        private void ShowTickets()
        {
            con.Open();
            string Query = "Select * from dbo.CUSTOMER";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
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

                    //-----------------
                    //string Query = "Select A from dbo.Flight";
                    //SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    //var ds = new DataSet();
                    //sda.Fill(ds);
                    //dataGridView1.DataSource = ds.Tables[0];

                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowTickets();
            }
        }

        private void view_or_delete_customer_Load(object sender, EventArgs e)
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
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.CUSTOMER where FLIGHTID='" + textBox1.Text + "' and SSN='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int numOfTicketsToDelete = Convert.ToInt32(dt.Rows[0][0].ToString());
                if (numOfTicketsToDelete >= 1)
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.CUSTOMER where FLIGHTID='" + textBox1.Text + "' and SSN='" + textBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    
                    
                    SqlCommand cmd2 = new SqlCommand("Update dbo.FLIGHT Set AVAILABLE_SEATS=AVAILABLE_SEATS+1 Where FLIGHTID=@FID", con);
                    cmd2.Parameters.AddWithValue("@FID", textBox1.Text);
                    cmd2.ExecuteNonQuery();

                    numOfTicketsToDelete--;

                    while (numOfTicketsToDelete >= 1)
                    {
                        SqlCommand cmd3 = new SqlCommand("insert into dbo.CUSTOMER(FLIGHTID, SSN, NAME, BIRTHDAY)values(@FID, @SSN, @NM, @BD)", con);
                        cmd3.Parameters.AddWithValue("@FID", textBox1.Text);
                        cmd3.Parameters.AddWithValue("@SSN", textBox2.Text);
                        cmd3.Parameters.AddWithValue("@NM", textBox3.Text);
                        cmd3.Parameters.AddWithValue("@BD", dateTimePicker1.Value);
                        cmd3.ExecuteNonQuery();
                        numOfTicketsToDelete--;
                    }


                    MessageBox.Show("Ticket Deleted");
                }
                else
                {
                    MessageBox.Show("Ticket Doesn't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            ShowTickets();
        }

        private void button4_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Update dbo.CUSTOMER Set FLIGHTID=@FID,SSN=@SSN,NAME=@NM,BIRTHDAY=@BD Where FLIGHTID=@NFID and SSN=@NSSN", con);
                    cmd.Parameters.AddWithValue("@FID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@SSN", textBox2.Text);
                    cmd.Parameters.AddWithValue("@NM", textBox3.Text);
                    cmd.Parameters.AddWithValue("@BD", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@NFID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@NSSN", textBox2.Text);

                    if(cmd.ExecuteNonQuery() >= 1)
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
                ShowTickets();
            }
        }
    }
}
