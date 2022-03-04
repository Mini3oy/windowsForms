namespace Enigneering
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Jokerman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(39, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(403, 70);
            this.label6.TabIndex = 17;
            this.label6.Text = "EngSE-Shoping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(142, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thank You.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(184, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 42);
            this.label2.TabIndex = 19;
            this.label2.Text = "谢谢.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(117, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 42);
            this.label3.TabIndex = 20;
            this.label3.Text = "ขอบคุณครับ/ค่ะ ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(357, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "กลับสู่หน้าหลัก";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(503, 305);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Form2";
            this.Text = "ขอบคุณคับ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}