
namespace Employee_Managemant_system
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_userid = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(445, 460);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(137, 23);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "OV Developer";
            // 
            // lbl_userid
            // 
            this.lbl_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.ForeColor = System.Drawing.Color.White;
            this.lbl_userid.Location = new System.Drawing.Point(649, 300);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(111, 26);
            this.lbl_userid.TabIndex = 1;
            this.lbl_userid.Text = "User Id";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(649, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tb_userid
            // 
            this.tb_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userid.Location = new System.Drawing.Point(838, 297);
            this.tb_userid.Name = "tb_userid";
            this.tb_userid.Size = new System.Drawing.Size(269, 38);
            this.tb_userid.TabIndex = 4;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(838, 374);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(269, 38);
            this.tb_password.TabIndex = 5;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(700, 505);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(162, 52);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(916, 505);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(162, 52);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(1391, 23);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(66, 20);
            this.lbl_close.TabIndex = 8;
            this.lbl_close.Text = "CLOSE";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1776, 796);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_userid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_userid;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_close;
    }
}