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
    public partial class add_or_edit_admin_Admin : Form
    {
        private main_screen_Admin obj;
        public add_or_edit_admin_Admin(main_screen_Admin obj)
        {
            this.obj = obj;
            InitializeComponent();
            ShowAdmins();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");

        private void ShowAdmins()
        {
            con.Open();
            string Query = "Select * from dbo.ADMIN";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("insert into dbo.ADMIN(ID, NAME, USERNAME, E_MAIL, PASSWORD)values(@ID, @NM, @US, @EM, @PS)", con);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@NM", textBox2.Text);
                    cmd.Parameters.AddWithValue("@US", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EM", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PS", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                ShowAdmins();
            }
        }



        private void add_or_edit_admin_Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
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
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.ADMIN where ID='" + textBox1.Text + "' and NAME='" + textBox2.Text + "' and USERNAME='" + textBox3.Text + "' and E_MAIL='" + textBox4.Text + "' and PASSWORD='" + textBox5.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.ADMIN where  ID='" + textBox1.Text + "' and NAME='" + textBox2.Text + "' and USERNAME='" + textBox3.Text + "' and E_MAIL='" + textBox4.Text + "' and PASSWORD='" + textBox5.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Deleted");
                }
                else
                {
                    MessageBox.Show("Admin Doesn't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            ShowAdmins();
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
                    SqlCommand cmd = new SqlCommand("Update dbo.ADMIN Set ID=@ID,NAME=@NM,USERNAME=@UNM,E_MAIL=@EM,PASSWORD=@PS Where ID=@OID", con);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@NM", textBox2.Text);
                    cmd.Parameters.AddWithValue("@UNM", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EM", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PS", textBox5.Text);
                    cmd.Parameters.AddWithValue("@OID", textBox1.Text);

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
                ShowAdmins();
            }
        }
    }
}
