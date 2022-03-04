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
using System.IO;

namespace Enigneering
{
    public partial class SALLdatan : Form
    {

        public SALLdatan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            objCmd = new SqlCommand("DELETE dbo.mana WHERE ID=@uid", objConn);
            objCmd.Parameters.AddWithValue("@uid", Convert.ToInt16(Num.Text));
            objCmd.ExecuteNonQuery();

            double pirB = Convert.ToDouble(pir.Text);
            double  Nome= Convert.ToDouble(Num.Text);
            double Result = 0;

            Result = pirB * Nome;
            reuslt.Text = Result.ToString();



              //-------------
            objConn.Close();
            objConn = null;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConn = null;
            string strSql = null;

            strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
            objConn.ConnectionString = strConn;
            objConn.Open();

            strSql = "INSERT INTO dbo.Sale_itam (NameSela, Price, Number,Model_name,Result) VALUES ('" + name.Text + "','" + pir.Text + "','" + Num.Text + "','" + textBox4NAme.Text + "','" + reuslt.Text + "')";

            objCmd.Connection = objConn;
            objCmd.CommandText = strSql;
            objCmd.CommandType = CommandType.Text;
            objCmd.ExecuteNonQuery();

            Form2 form2 = new Form2();
            form2.ShowDialog();

            objConn.Close();
            objConn = null;

            this.Hide();
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string imgLoc = "";
            //SqlConnection objConn = new SqlConnection("Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber");
            //byte[] img = null;
            //FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //img = br.ReadBytes((int)fs.Length);
            //string strConn = null;
            //string strSql = null;
            //objConn.ConnectionString = strConn;
            //objConn.Open();
            //SqlCommand objCmd = new SqlCommand("SELECT imgfile FROM dbo.SALLdata WHERE Image=@img",objConn);
            //objCmd.Parameters.Add(new SqlParameter("@img", img));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Hide();
        }

        private void SALLdatan_Load(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand OjbCmd = new SqlCommand();
            string strConn = null;
          

            

            strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
            objConn.ConnectionString = strConn;
            objConn.Open();

            string sql = "SELECT Image,ID,Name_sall,pir FROM dbo.SALLdata WHERE ID = '" + label8.Text + "'";
            if (objConn.State != ConnectionState.Open)
                objConn.Open();
            SqlCommand Command = new SqlCommand(sql, objConn);
            SqlDataReader reader = Command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                byte[] img = (byte[])(reader[0]);
                if (img == null)
                    pictureBox1.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
         
            }
            else
            {
                id.Text = "";
                pir.Text = "";
                reuslt.Text = "";
                pictureBox1.Image = null;
                MessageBox.Show("not show image");


            }

        }

    }
}
