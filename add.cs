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
    public partial class add : Form
    {
        SqlConnection objConn = new SqlConnection("Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber");
        SqlCommand objCmd ;
        string strConn = null;
        string strSql = null;
        string imgLoc = "";
        
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                strSql = "INSERT INTO dbo.SALLdata (Name_sall, Numer, pir, Name_sall2, IT,Image) VALUES ('" + textnamesall.Text + "','" + textnubersall.Text + "','" + textprice.Text + "','" + textnameSALL2.Text + "','" + textcat_name.Text + "',@img)";
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();
                objCmd = new SqlCommand(strSql, objConn);
                objCmd.Parameters.Add(new SqlParameter("@img", img));
                int x = objCmd.ExecuteNonQuery();
                objConn.Close();
                MessageBox.Show(x.ToString() + "เพิ่มสำเร็จ");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All files(*.*)|*.*";
                dlg.Title = "Selet Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void add_Load(object sender, EventArgs e)
        {
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textnamesall_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
