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
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }

        Config o = new Config();   //Databass Connaction
        SqlDataAdapter da;
        DataTable dt;

        public void clear()
        {
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Text4.Text = "";
            Text5.Text = "";
            Text6.Text = "";
            Text7.Text = "";
            Text8.Text = "";
            o.Loadgid("SELECT ID as 'Id',PACKAGE_NAME  as 'Name',MAXIMUM_KM  as 'Max_KM',MAXIMUM_HOURS as 'Max_HR',EXTRA_KM_CHARG  as 'Ex_KM_C',WAITITING_CHARG as 'Wit_C',DRIVER_OVERNIGHT_CHARG as 'Driver_OV_C',VEHICLE_PARK_CHARG as 'Vehicle_C',DRIVER_CHARG as 'Driver_C' FROM Package ORDER BY ID DESC", DataGrid);
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            Settings OBJ = new Settings();
            OBJ.Show();
            this.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (Text1.Text != "" && Text2.Text != "" && Text3.Text != "" && Text4.Text != "" && Text5.Text != "")
            {
                try
                {
                    o.con.Open();
                    string qry = "INSERT INTO [Package] (PACKAGE_NAME,MAXIMUM_KM,MAXIMUM_HOURS,EXTRA_KM_CHARG,WAITITING_CHARG,DRIVER_OVERNIGHT_CHARG,VEHICLE_PARK_CHARG,DRIVER_CHARG) VALUES ('" + Text1.Text + "','" + Text2.Text + "','" + Text3.Text + "','" + Text4.Text + "','" + Text5.Text + "','" + Text6.Text + "','" + Text7.Text + "','" + Text8.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Your Package is entered";
                    {
                        clear();
                    }
                }
                catch
                {
                    Message.ForeColor = Color.Red;
                    // Message.Text = "Last 4 Feld Use INT Number Only";
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

        private void Package_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            da = new SqlDataAdapter("SELECT ID as 'Id',PACKAGE_NAME  as 'Name',MAXIMUM_KM  as 'Max_KM',MAXIMUM_HOURS as 'Max_HR',EXTRA_KM_CHARG  as 'Ex_KM_C',WAITITING_CHARG as 'Wit_C',DRIVER_OVERNIGHT_CHARG as 'Driver_OV_C',VEHICLE_PARK_CHARG as 'Vehicle_C',DRIVER_CHARG as 'Driver_C' FROM Package ORDER BY ID DESC", o.con);
            dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
        }

        private void ButtonViwe_Click(object sender, EventArgs e)
        {
            if (ButtonViwe.Text == "Viwe On")
            {
                panel4.Show();
                ButtonViwe.Text = "Viwe Off";
            }

            else if (ButtonViwe.Text == "Viwe Off")
            {
                panel4.Hide();
                ButtonViwe.Text = "Viwe On";
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            clear();
            ID.Text = "";
            Message.Text = "";
            ButtonAdd.Enabled = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ID.Text != "")
            {
                try
                {
                    o.con.Open();
                    string delete_Quary = "DELETE Package WHERE ID ='" + ID.Text + "'";
                    SqlCommand cmd = new SqlCommand(delete_Quary, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Your Package has deleted";
                    {
                        clear();
                        ButtonAdd.Enabled = true;

                    }
                }
                catch
                {
                    Message.ForeColor = Color.Blue;
                    //  Message.Text = "Select your vehicle";
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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (ID.Text != "")
            {
                try
                {
                    o.con.Open();
                    string update_query = "UPDATE Package SET PACKAGE_NAME ='" + Text1.Text + "',MAXIMUM_KM ='" + Text2.Text + "',MAXIMUM_HOURS ='" + Text3.Text + "',EXTRA_KM_CHARG ='" + Text4.Text + "',WAITITING_CHARG ='" + Text5.Text + "',DRIVER_OVERNIGHT_CHARG ='" + Text6.Text + "',VEHICLE_PARK_CHARG ='" + Text7.Text + "',DRIVER_CHARG ='" + Text8.Text + "' where ID ='" + ID.Text + "'";
                    SqlCommand cmd = new SqlCommand(update_query, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Your Package has updated";
                    {
                        clear();
                        ButtonAdd.Enabled = true;
                        ID.Text = "";
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
                Message.Text = "Select your Package";
            }
        }

        private void B_Home_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }

        private void B_Vehicles_Click(object sender, EventArgs e)
        {
            Add_to_Vehicles OBJ = new Add_to_Vehicles();
            OBJ.Show();
            this.Hide();
        }

        private void B_pakage_Click(object sender, EventArgs e)
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

        private void B_DayTour_Click(object sender, EventArgs e)
        {
            Day_Tour OBJ = new Day_Tour();
            OBJ.Show();
            this.Hide();
        }

        private void B_LogOut_Click(object sender, EventArgs e)
        {
            Login OBJ = new Login();
            OBJ.Show();
            this.Hide();
        }

        private void BunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text != "")
            {
                o.Loadgid("SELECT ID as 'Id',PACKAGE_NAME  as 'Name',MAXIMUM_KM  as 'Max_KM',MAXIMUM_HOURS as 'Max_HR',EXTRA_KM_CHARG  as 'Ex_KM_C',WAITITING_CHARG as 'Wit_C',DRIVER_OVERNIGHT_CHARG as 'Driver_OV_C',VEHICLE_PARK_CHARG as 'Vehicle_C',DRIVER_CHARG as 'Driver_C' FROM Package WHERE ID LIKE '%" + bunifuMaterialTextbox5.Text + "%' OR PACKAGE_NAME LIKE '%" + bunifuMaterialTextbox5.Text + "%'", DataGrid);

            }
            else
            {
                o.Loadgid("SELECT ID as 'Id',PACKAGE_NAME  as 'Name',MAXIMUM_KM  as 'Max_KM',MAXIMUM_HOURS as 'Max_HR',EXTRA_KM_CHARG  as 'Ex_KM_C',WAITITING_CHARG as 'Wit_C',DRIVER_OVERNIGHT_CHARG as 'Driver_OV_C',VEHICLE_PARK_CHARG as 'Vehicle_C',DRIVER_CHARG as 'Driver_C' FROM Package ORDER BY ID DESC", DataGrid);
            }
        }

        private void DataGrid_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Message.Text = "";
            ButtonAdd.Enabled = false;
            ID.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            Text1.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Text2.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Text3.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            Text4.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Text5.Text = DataGrid.SelectedRows[0].Cells[5].Value.ToString();
            Text6.Text = DataGrid.SelectedRows[0].Cells[6].Value.ToString();
            Text7.Text = DataGrid.SelectedRows[0].Cells[7].Value.ToString();
            Text8.Text = DataGrid.SelectedRows[0].Cells[8].Value.ToString();
            panel4.Hide();
            ButtonViwe.Text = "Viwe On";
        }
    }
}
