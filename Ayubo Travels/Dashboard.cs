﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_Travels
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Login OBJ = new Login();
            OBJ.Show();
            this.Hide();
        }

        private void B_Home_Click_1(object sender, EventArgs e)
        {

        }

        private void B_Add_Click_1(object sender, EventArgs e)
        {

        }

        private void B_Viwe_Click(object sender, EventArgs e)
        {

        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            Settings OBJ = new Settings();
            OBJ.Show();
            this.Hide();
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {

        }

      
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void B_Home_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            Add_to_Vehicles OBJ = new Add_to_Vehicles();
            OBJ.Show();
            this.Hide();
        }

        private void B_Viwe_Click_1(object sender, EventArgs e)
        {
            Package OBJ = new Package();
            OBJ.Show();
            this.Hide();
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            Rent OBJ = new Rent();
            OBJ.Show();
            this.Hide();
        }

        private void B_Database_Click(object sender, EventArgs e)
        {
            Day_Tour OBJ = new Day_Tour();
            OBJ.Show();
            this.Hide();
        }

        private void B_Settings_Click_1(object sender, EventArgs e)
        {

        }

        private void B_LogOut_Click(object sender, EventArgs e)
        {
            Login OBJ = new Login();
            OBJ.Show();
            this.Hide();
        }

        private void B_Twitter_Click(object sender, EventArgs e)
        {

        }

        private void B_Facebook_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
