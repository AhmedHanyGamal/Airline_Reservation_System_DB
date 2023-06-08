using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_reservation_system
{
    public partial class main_screen_Admin : Form
    {
        private Admin_login obj;
        public main_screen_Admin(Admin_login obj)
        {
            this.obj = obj;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-AO07VC2;Database=Please_work_DB;Trusted_Connection=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void main_screen_Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Close();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel17_Click(object sender, EventArgs e)
        {
            add_or_edit_admin_Admin manage_admin = new add_or_edit_admin_Admin(this);
            manage_admin.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SSN, COUNT(*) AS ticket_count FROM dbo.CUSTOMER GROUP BY SSN ORDER BY ticket_count DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT NAME FROM dbo.CUSTOMER Where SSN='"+ dt.Rows[0][0].ToString() + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            MessageBox.Show("The Our Top Customer at the moment is " + dt2.Rows[0][0].ToString() + ", With SSN: " + dt.Rows[0][0].ToString() + ".\nAs he has bought " + dt.Rows[0][1].ToString() + " Tickets");
            con.Close();
            //throw new NotImplementedException();
        }
        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.CUSTOMER", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show("The number of Tickets sold since the Airline system was made is " + dt.Rows[0][0].ToString() + " Tickets");
            con.Close();
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}