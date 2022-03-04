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
    public partial class Delet : Form
    {
        public Delet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConn = null;
            string strSql = null;
            // localhost ---> .\\SQL Name .\\SQLEXPRESS01
            strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
            objConn.ConnectionString = strConn;
            objConn.Open();
            // SQL Command
            objCmd = new SqlCommand("DELETE dbo.SALLdata WHERE ID=@uid", objConn);
            objCmd.Parameters.AddWithValue("@uid", Convert.ToInt16(textBox1.Text));
            objCmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            //-------------
            objConn.Close();
            objConn = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            adapt = new SqlDataAdapter("SELECT * FROM dbo.SALLdata WHERE Name_sall2 LIKE '" + textBox1.Text + "%'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;



            objConn.Close();
            objConn = null;
        }

        private void Delet_Load(object sender, EventArgs e)
        {

            SqlConnection objConn = new SqlConnection("Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber");
            SqlCommand objCmd;
            SqlDataAdapter da;
            string select = "SELECT * FROM dbo.SALLdata";
            objCmd = new SqlCommand(select, objConn);
            da = new SqlDataAdapter(objCmd);

            DataTable table = new DataTable();

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 120;

            dataGridView2.AllowUserToAddRows = false;
            da.Fill(table);
            
            dataGridView2.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            imageColumn = (DataGridViewImageColumn)dataGridView2.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            da.Dispose();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
