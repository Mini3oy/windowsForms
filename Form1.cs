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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbuser.Checked)
            {
                SqlConnection objConn = new SqlConnection();
                SqlCommand objCmd = new SqlCommand();
                string strConn = null;
                string strSql = null;
                int row = 0;
                strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
                objConn.ConnectionString = strConn;
                objConn.Open();
                strSql = "SELECT COUNT(*) FROM dbo.USERa  WHERE Username = '" + txtusername.Text + "' AND Password = '" + txtpassword.Text + "'";
                objCmd = new SqlCommand(strSql, objConn);
                row = Convert.ToInt16(objCmd.ExecuteScalar());

                if (row > 0)
                {
                    MessageBox.Show(" รหัสถูกต้อง! ");
                    string D = txtusername.Text;
                    Home home = new Home();
                    home.ShowDialog();

                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่าน ผิด !!!");
                }

                objConn.Close();
                objConn = null;
            }
            else if (rbadmin.Checked)
            {
                SqlConnection objConn = new SqlConnection();
                SqlCommand objCmd = new SqlCommand();
                string strConn = null;
                string strSql = null;
                int row = 0;
                strConn = "Server=.\\SQLEXPRESS;UID=wongsalee1;PASSWORD=12345;Database=menber";
                objConn.ConnectionString = strConn;
                objConn.Open();
                strSql = "SELECT COUNT(*) FROM dbo.Admin  WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                objCmd = new SqlCommand(strSql, objConn);
                row = Convert.ToInt16(objCmd.ExecuteScalar());

                if (row > 0)
                {
                    MessageBox.Show(" รหัสถูกต้อง! ");
                    admin admin = new admin();
                    admin.ShowDialog();

                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่าน ผิด !!!");
                }

                objConn.Close();
                objConn = null;

            }
            else
            {
                MessageBox.Show("โปรดเลือกคลาส Admin หรือ User !!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
   
        
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
