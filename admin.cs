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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            dataGridView1.DataSource = dt;


            objConn.Close();
            objConn = null;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void admin_Load(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection("Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber");
            SqlCommand objCmd;
            SqlDataAdapter da;
            string select = "SELECT * FROM dbo.SALLdata";
            objCmd = new SqlCommand(select, objConn);
            da = new SqlDataAdapter(objCmd);

            DataTable table = new DataTable();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 150;

            dataGridView1.AllowUserToAddRows = false;
            da.Fill(table);

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

        
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            da.Dispose();

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
            adapt = new SqlDataAdapter("SELECT * FROM dbo.SALLdata WHERE Name_sall2 LIKE '" + textBox1.Text + "%'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            objConn.Close();
            objConn = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delet delet = new Delet();
            delet.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Saleitem saleitem = new Saleitem();
            saleitem.ShowDialog();

        }
    }
}
