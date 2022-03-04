namespace Enigneering
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.rbuser = new System.Windows.Forms.RadioButton();
            this.txtusername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "EngSE-Shoping";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Angsana New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtpassword.Location = new System.Drawing.Point(168, 197);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(180, 28);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Angsana New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(260, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "เข้าสู่ระบบ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Angsana New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.Location = new System.Drawing.Point(188, 264);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 22);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "สมัครสมาชิก";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Angsana New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(163, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "ผู้ใช้งาน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Angsana New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(164, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "รหัสผ่าน";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Angsana New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox1.Location = new System.Drawing.Point(168, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 26);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "แสดงรหัสผ่าน";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.BackColor = System.Drawing.Color.Transparent;
            this.rbadmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbadmin.Location = new System.Drawing.Point(221, 107);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(54, 17);
            this.rbadmin.TabIndex = 11;
            this.rbadmin.TabStop = true;
            this.rbadmin.Text = "Admin";
            this.rbadmin.UseVisualStyleBackColor = false;
            // 
            // rbuser
            // 
            this.rbuser.AutoSize = true;
            this.rbuser.BackColor = System.Drawing.Color.Transparent;
            this.rbuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbuser.Location = new System.Drawing.Point(281, 108);
            this.rbuser.Name = "rbuser";
            this.rbuser.Size = new System.Drawing.Size(47, 17);
            this.rbuser.TabIndex = 12;
            this.rbuser.TabStop = true;
            this.rbuser.Text = "User";
            this.rbuser.UseVisualStyleBackColor = false;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.Window;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Angsana New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtusername.Location = new System.Drawing.Point(169, 137);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(180, 28);
            this.txtusername.TabIndex = 13;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 317);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.rbuser);
            this.Controls.Add(this.rbadmin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "เข้าสู่ระบบ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbadmin;
        private System.Windows.Forms.RadioButton rbuser;
        private System.Windows.Forms.TextBox txtusername;
    }
}

