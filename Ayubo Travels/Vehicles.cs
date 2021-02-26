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

namespace Ayubo_Travels
{
    public partial class Add_to_Vehicles : Form
    {
        public Add_to_Vehicles()
        {
            InitializeComponent();
        }

        private void Add_to_Vehicles_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT ID as 'Id',VEHICLE_TYPE as 'Type',VEHICLE_MODEL as 'Model',VEHICLE_NUMBER as 'Number',DAY_RATE as 'Day',WEEK_RATE as 'Week',MONTH_RATE as 'Month' FROM Vehicles ORDER BY ID DESC", o.con);
            dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
        }

        Config o = new Config();   //Databass Connaction
        SqlDataAdapter da;
        DataTable dt;

        private void B_Close_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label2.Hide();
            Message.Text = "";
        }

        private void ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            label3.Hide();

        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            Settings OBJ = new Settings();
            OBJ.Show();
            this.Hide();
        }

        public void clear()
        {
            label2.Show();
            label3.Show();
            ID.Text = "";
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Text4.Text = "";
            o.Loadgid("SELECT ID as 'Id',VEHICLE_TYPE as 'Type',VEHICLE_MODEL as 'Model',VEHICLE_NUMBER as 'Number',DAY_RATE as 'Day',WEEK_RATE as 'Week',MONTH_RATE as 'Month' FROM Vehicles ORDER BY ID DESC", DataGrid);
        }

        private void ButtonAdd_Click(object sender, EventArgs e) // Add
        {
            if (combo1.Text != "" && combo2.Text != "" && Text1.Text != "" && Text2.Text != "" && Text3.Text != "")
            {
                try
                {
                    o.con.Open();
                    string qry = "INSERT INTO [Vehicles] (VEHICLE_TYPE,VEHICLE_MODEL,VEHICLE_NUMBER,DAY_RATE,WEEK_RATE,MONTH_RATE) VALUES " +
                    "('" + combo1.Text + "','" + combo2.Text + "','" + Text1.Text + "','" + Text2.Text + "','" + Text3.Text + "','" + Text4.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Your vehicle is entered";
                    {
                        clear();
                    }
                }
                catch
                {
                    Message.ForeColor = Color.Red;
                    //Message.Text = "Last 4 Feld Use INT Number Only";
                }
                finally
                {
                    o.con.Close();
                }
            }
            else
            {
                Message.ForeColor = Color.Red;
                Message.Text = "Fill all required fields";
            }
        }

        private void BunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text != "")
            {
                o.Loadgid("SELECT ID as 'Id',VEHICLE_TYPE as 'Type',VEHICLE_MODEL as 'Model',VEHICLE_NUMBER as 'Number',DAY_RATE as 'Day',WEEK_RATE as 'Week',MONTH_RATE as 'Month' FROM Vehicles WHERE ID LIKE '%" + bunifuMaterialTextbox5.Text + "%' OR VEHICLE_TYPE LIKE '%" + bunifuMaterialTextbox5.Text + "%'", DataGrid);

            }
            else
            {
                o.Loadgid("SELECT ID as 'Id',VEHICLE_TYPE as 'Type',VEHICLE_MODEL as 'Model',VEHICLE_NUMBER as 'Number',DAY_RATE as 'Day',WEEK_RATE as 'Week',MONTH_RATE as 'Month' FROM Vehicles ORDER BY ID DESC", DataGrid);
            }
        }

        private void Search_Click(object sender, EventArgs e) // Search
        {
         
        }

        private void ButtonDelete_Click(object sender, EventArgs e) // Delete
        {
            if (ID.Text != "")
            {
                try
                {
                    o.con.Open();
                    string delete_Quary = "DELETE Vehicles WHERE ID ='" + ID.Text + "'";
                    SqlCommand cmd = new SqlCommand(delete_Quary, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Your vehicle has deleted";
                    {
                        clear();
                        ButtonAdd.Enabled = true;
                    }
                }
                catch
                {
                    Message.ForeColor = Color.Blue;
                    //Message.Text = "Select your vehicle";
                }
                finally
                {
                    o.con.Close();
                }
            }
            else
            {
                Message.ForeColor = Color.Blue;
                Message.Text = "Select your vehicle";
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e) //Update
        {
            if (ID.Text != "")
            {
                try
                {
                    o.con.Open();
                    string update_query = "UPDATE Vehicles SET VEHICLE_TYPE='" + combo1.Text + "',VEHICLE_MODEL='" + combo2.Text + "',VEHICLE_NUMBER='" + Text1.Text + "'," +
                        "DAY_RATE='" + Text2.Text + "',WEEK_RATE='" + Text3.Text + "',MONTH_RATE='" + Text4.Text + "' where ID ='" + ID.Text + "'";
                    SqlCommand cmd = new SqlCommand(update_query, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Your vehicle has updated";
                    {
                        clear();
                        ButtonAdd.Enabled = true;
                    }
                }
                catch
                {
                    Message.ForeColor = Color.Blue;
                    // Message.Text = "Select your vehicle";
                }
                finally
                {
                    o.con.Close();
                }
            }
            else
            {
                Message.ForeColor = Color.Blue;
                Message.Text = "Select your vehicle";
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            clear();
            ButtonAdd.Enabled = true;
            Message.Text = "";
        }

        private void DataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Message.Text = "";
            ButtonAdd.Enabled = false;
            ID.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            combo1.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            combo2.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Text1.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            Text2.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Text3.Text = DataGrid.SelectedRows[0].Cells[5].Value.ToString();
            Text4.Text = DataGrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void B_Home_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }

        private void B_LogOut_Click(object sender, EventArgs e)
        {
            Login OBJ = new Login();
            OBJ.Show();
            this.Hide();
        }

        private void B_Log_Click(object sender, EventArgs e)
        {

        }

        private void B_DatTour_Click(object sender, EventArgs e)
        {
            Day_Tour OBJ = new Day_Tour();
            OBJ.Show();
            this.Hide();
        }

        private void B_Rent_Click(object sender, EventArgs e)
        {
            Rent OBJ = new Rent();
            OBJ.Show();
            this.Hide();
        }

        private void B_Pakage_Click(object sender, EventArgs e)
        {
            Package OBJ = new Package();
            OBJ.Show();
            this.Hide();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            Add_to_Vehicles OBJ = new Add_to_Vehicles();
            OBJ.Show();
            this.Hide();
        }

        private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}