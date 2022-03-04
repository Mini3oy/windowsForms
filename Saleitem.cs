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
    public partial class Saleitem : Form
    {
        public Saleitem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConn = null;
            string strSql = null;
            //-----
            SqlDataAdapter adapt;
            DataTable dt;
            // localhost --->.\\SQL Name .\\SQLEXPRESS
            strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
            objConn.ConnectionString = strConn;
            objConn.Open();
            //SQL Commmand
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Sale_itam WHERE Namesela LIKE '" + textBox2.Text + "%'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;


            objConn.Close();
            objConn = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConn = null;
            string strSql = null;
            //-----
            SqlDataAdapter adapt;
            DataTable dt;
            // localhost --->.\\SQL Name .\\SQLEXPRESS
            strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
            objConn.ConnectionString = strConn;
            objConn.Open();
            //SQL Commmand
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Sale_itam WHERE Namesela LIKE '" + textBox2.Text + "%'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;


            objConn.Close();
            objConn = null;
        }
    }
}
