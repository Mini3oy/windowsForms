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

namespace Enigneering
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConn = null;
            string strSql = null;

            strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
            objConn.ConnectionString = strConn;
            objConn.Open();

            strSql = "INSERT INTO dbo.USERa (Name_lastname,Username,Password,E_mail,Telaphon,address) VALUES ('" + textuesrlast.Text + "','"+ textuser.Text + "','" + textpass.Text +"','" + textemail.Text + "','" + textphon.Text + "','"+textaddress.Text+"')";
            objCmd.Connection = objConn;
            objCmd.CommandText = strSql;
            objCmd.CommandType = CommandType.Text;
            objCmd.ExecuteNonQuery();

            objConn.Close();
            objConn = null;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
