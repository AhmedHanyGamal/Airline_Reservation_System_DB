using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_reservation_system
{
    public partial class starting_form : Form
    {
        public starting_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            view_all_flights view_all_flights_form = new view_all_flights(this);
            view_all_flights_form.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Admin_login Admin_login_form = new Admin_login(this);
            Admin_login_form.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
