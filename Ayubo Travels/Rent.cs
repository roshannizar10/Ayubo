using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Travels
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Login OBJ = new Login();
            OBJ.Show();
            this.Hide();
        }

        private void B_Home_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }

        private void B_Vahical_Click(object sender, EventArgs e)
        {
            Add_to_Vehicles OBJ = new Add_to_Vehicles();
            OBJ.Show();
            this.Hide();
        }

        private void B_Pakage_Click(object sender, EventArgs e)
        {
            Package OBJ = new Package();
            OBJ.Show();
            this.Hide();
        }

        private void B_Rent_Click(object sender, EventArgs e)
        {
            Rent OBJ = new Rent();
            OBJ.Show();
            this.Hide();
        }

        private void B_DayRent_Click(object sender, EventArgs e)
        { 
            Day_Tour OBJ = new Day_Tour();
            OBJ.Show();
            this.Hide();
        }

        private void B_Log_Click(object sender, EventArgs e)
        {

        }

        private void B_LogOut_Click(object sender, EventArgs e)
        {
            Login OBJ = new Login();
            OBJ.Show();
            this.Hide();
        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            Settings OBJ = new Settings();
            OBJ.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Text2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
