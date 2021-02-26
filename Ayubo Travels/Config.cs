using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_Travels
{
    class Config
    {
        public SqlConnection con;
        public string str;
        public Config()
        {
            try   //Databass Connaction
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Riyasha Nizar\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30";
                con = new SqlConnection(str);
                con.Open();
                //MessageBox.Show("Database Connected");

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void Loadgid(string qry, DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(qry, con);
            da.SelectCommand = cmd;
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];
            da.Dispose();
            cmd.Dispose();
        }
    }
}
