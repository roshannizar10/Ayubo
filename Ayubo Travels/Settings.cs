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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Dashboard OBJ = new Dashboard();
            OBJ.Show();
            this.Hide();
        }
        Config o = new Config();   //Databass Connaction
        SqlDataAdapter da;
        DataTable dt;

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                o.con.Open();
                string Search = "SELECT * FROM Login WHERE PASSWORD ='" + bunifuMaterialTextbox2.Text + "'";
                SqlCommand cmd = new SqlCommand(Search, o.con);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Message.ForeColor = Color.Green;
                    Message.Text = "Old password is success";
                    //ID.Text = r[0].ToString();

                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox2.Enabled = false;
                    bunifuMaterialTextbox3.Enabled = true;
                    bunifuFlatButton2.Show();

                }
            }
            catch (Exception)
            {
                Message.ForeColor = Color.Red;
                //Message.Text = "Quary Error";

            }
            finally
            {
                o.con.Close();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM [Table]", o.con);
            dt = new DataTable();
            da.Fill(dt);
            //DataGrid.DataSource = dt;

            bunifuMaterialTextbox1.Enabled = false;
            bunifuMaterialTextbox3.Enabled = false;
            bunifuFlatButton2.Hide();
            //DataGrid.Hide();
            //ID.Hide();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox3.Text != "")
            {
                try
                {
                    o.con.Open();
                    string update_query = "UPDATE Login SET PASSWORD ='" + bunifuMaterialTextbox1.Text + "' where ID ='" + 1 + "'";
                    SqlCommand cmd = new SqlCommand(update_query, o.con);
                    cmd.ExecuteNonQuery();
                    Message.ForeColor = Color.Green;
                    Message.Text = "Password is changed";

                    {
                        bunifuMaterialTextbox1.Text = "";
                        bunifuMaterialTextbox2.Text = "";
                        bunifuMaterialTextbox3.Text = "";
                        bunifuMaterialTextbox1.Enabled = false;
                        bunifuMaterialTextbox2.Enabled = true;
                        bunifuMaterialTextbox3.Enabled = false;
                        bunifuFlatButton2.Hide();
                        //o.Loadgid("SELECT * FROM Login", DataGrid);
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
                Message.Text = "Enter Conform Password";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
