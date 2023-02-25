
namespace Employee_Managemant_system
{
    partial class Ordermsystemhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordermsystemhome));
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_attenreport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menupanal = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_or = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Menupanal.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(38, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Main Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btn_attenreport);
            this.panel4.Location = new System.Drawing.Point(3, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 36);
            this.panel4.TabIndex = 7;
            // 
            // btn_attenreport
            // 
            this.btn_attenreport.BackColor = System.Drawing.Color.Black;
            this.btn_attenreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_attenreport.ForeColor = System.Drawing.Color.White;
            this.btn_attenreport.Location = new System.Drawing.Point(0, 0);
            this.btn_attenreport.Name = "btn_attenreport";
            this.btn_attenreport.Size = new System.Drawing.Size(213, 36);
            this.btn_attenreport.TabIndex = 1;
            this.btn_attenreport.Text = "View Orders";
            this.btn_attenreport.UseVisualStyleBackColor = false;
            this.btn_attenreport.Click += new System.EventHandler(this.btn_attenreport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1226, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "OV Developers";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Black;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(38, 687);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(123, 39);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 127);
            this.panel1.TabIndex = 0;
            // 
            // Menupanal
            // 
            this.Menupanal.AutoScroll = true;
            this.Menupanal.BackColor = System.Drawing.Color.Black;
            this.Menupanal.Controls.Add(this.button2);
            this.Menupanal.Controls.Add(this.button1);
            this.Menupanal.Controls.Add(this.btn_or);
            this.Menupanal.Controls.Add(this.panel4);
            this.Menupanal.Controls.Add(this.btnlogout);
            this.Menupanal.Controls.Add(this.btn_home);
            this.Menupanal.Controls.Add(this.panel1);
            this.Menupanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanal.Location = new System.Drawing.Point(0, 0);
            this.Menupanal.Name = "Menupanal";
            this.Menupanal.Size = new System.Drawing.Size(216, 749);
            this.Menupanal.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 68);
            this.button2.TabIndex = 13;
            this.button2.Text = "ORDERS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_or
            // 
            this.btn_or.BackColor = System.Drawing.Color.Black;
            this.btn_or.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_or.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_or.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_or.ForeColor = System.Drawing.Color.White;
            this.btn_or.Location = new System.Drawing.Point(0, 190);
            this.btn_or.Name = "btn_or";
            this.btn_or.Size = new System.Drawing.Size(216, 68);
            this.btn_or.TabIndex = 11;
            this.btn_or.Text = "USERS";
            this.btn_or.UseVisualStyleBackColor = false;
            this.btn_or.Click += new System.EventHandler(this.btn_or_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Black;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 127);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(216, 63);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_home.Controls.Add(this.label1);
            this.panel_home.Location = new System.Drawing.Point(216, 0);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1758, 749);
            this.panel_home.TabIndex = 4;
            this.panel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_home_Paint);
            // 
            // Ordermsystemhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1758, 749);
            this.Controls.Add(this.Menupanal);
            this.Controls.Add(this.panel_home);
            this.Name = "Ordermsystemhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordermsystemhome";
            this.Load += new System.EventHandler(this.Ordermsystemhome_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Menupanal.ResumeLayout(false);
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_attenreport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Menupanal;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_or;
    }
}