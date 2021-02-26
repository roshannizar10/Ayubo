using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Ayubo_Travels
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int Wparam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }


        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Config o = new Config();   //Databass Connaction

            string qry;
            SqlCommand cmd;
            try
            {
                qry = "SELECT USERNAME,PASSWORD FROM [Table] WHERE USERNAME='" + TextUsername.Text + "' AND PASSWORD='" + TextPassword.Text + "'";
                cmd = new SqlCommand(qry, o.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Dispose(false);
                    Dashboard OBJ = new Dashboard();//Open Dashboard
                    OBJ.Show();
                }
                else
                {
                    Message.ForeColor = Color.Red;
                    Message.Text = "Invalid Username Or Password";
                    TextPassword.Text = "";
                    TextPassword.Focus();
                    dr.Close();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show("error : " + x.Message);
            }



            // Dashboard OBJ = new Dashboard();
            // this.Hide();
            // OBJ.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
