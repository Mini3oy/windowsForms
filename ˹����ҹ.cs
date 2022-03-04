using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Enigneering
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //SALLdatan sAL = new SALLdatan();

            //sAL.name.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //sAL.pir.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //sAL.Num.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //sAL.textBox4NAme.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //sAL.pictureBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //sAL.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            
            SALLdatan sAL = new SALLdatan();

            sAL.label8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sAL.name.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sAL.pir.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sAL.Num.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sAL.textBox4NAme.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

            //SqlConnection objConn = new SqlConnection("Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber");
            //SqlCommand command = new SqlCommand("Insert INTO dbo.SALLdata (Image) VALUES(@img) ");
            //FileStream fs = new FileStream(op.FileName);
        

            double pirB = Convert.ToDouble(sAL.pir.Text);
            double Nome = Convert.ToDouble(sAL.Num.Text);
            double Result = 0;

            Result = pirB * Nome;
            sAL.reuslt.Text = Result.ToString();



            

            sAL.ShowDialog();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection("Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber");
            SqlCommand objCmd;
            SqlDataAdapter da;
            string select = "SELECT * FROM dbo.SALLdata";
            objCmd = new SqlCommand(select, objConn);
            da = new SqlDataAdapter(objCmd);

            DataTable table = new DataTable();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            dataGridView1.AllowUserToAddRows = false;
            da.Fill(table);

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            da.Dispose();







        }

        private void button2_Click(object sender, EventArgs e)
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
            adapt = new SqlDataAdapter("SELECT * FROM dbo.SALLdata WHERE IT LIKE 'Computer'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


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
            adapt = new SqlDataAdapter("SELECT * FROM dbo.SALLdata WHERE IT LIKE 'Notebook'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            objConn.Close();
            objConn = null;
        }

        private void button4_Click(object sender, EventArgs e)
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
            adapt = new SqlDataAdapter("SELECT * FROM dbo.SALLdata WHERE IT LIKE 'Telephon'", objConn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            objConn.Close();
            objConn = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
