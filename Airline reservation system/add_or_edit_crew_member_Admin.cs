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
    public partial class add_or_edit_crew_member_Admin : Form
    {
        main_screen_Admin obj;
        public add_or_edit_crew_member_Admin(main_screen_Admin obj)
        {
            this.obj = obj;
            InitializeComponent();
            ShowCrewMembers();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");

        private void ShowCrewMembers()
        {
            con.Open();
            string Query = "Select * from dbo.CREW_MEMBER";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into dbo.CREW_MEMBER(CREWID, FLIGHTID, NAME, POSITION)values(@CID, @FID, @NM, @PS)", con);
                    cmd.Parameters.AddWithValue("@CID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@FID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@NM", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PS", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Crew Member added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowCrewMembers();
            }
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
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.CREW_MEMBER where CREWID='" + textBox1.Text + "' and FLIGHTID='" + textBox2.Text + "' and NAME='" + textBox3.Text + "' and POSITION='" + textBox4.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.CREW_MEMBER where CREWID='" + textBox1.Text + "' and FLIGHTID='" + textBox2.Text + "' and NAME='" + textBox3.Text + "' and POSITION='" + textBox4.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Crew Member Deleted from Database");
                }
                else
                {
                    MessageBox.Show("Crew Member Doesn't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            ShowCrewMembers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Update dbo.CREW_MEMBER Set CREWID=@CID,FLIGHTID=@FID,NAME=@NM,POSITION=@POS Where CREWID=@CID", con);
                    cmd.Parameters.AddWithValue("@CID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@FID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@NM", textBox3.Text);
                    cmd.Parameters.AddWithValue("@POS", textBox4.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Crew Member Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Crew Member Update FAILED");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowCrewMembers();
            }
        }
    }
}
