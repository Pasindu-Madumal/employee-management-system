
namespace Employee_Managemant_system
{
    partial class OrderHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHome));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menupanal = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_additem = new System.Windows.Forms.Button();
            this.panel_home1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Menupanal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_home1.SuspendLayout();
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
            // btn_item
            // 
            this.btn_item.BackColor = System.Drawing.Color.Black;
            this.btn_item.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_item.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ForeColor = System.Drawing.Color.White;
            this.btn_item.Location = new System.Drawing.Point(0, 190);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(216, 70);
            this.btn_item.TabIndex = 4;
            this.btn_item.Text = "ITEMS";
            this.btn_item.UseVisualStyleBackColor = false;
            this.btn_item.Click += new System.EventHandler(this.btn_employee_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 109);
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
            this.Menupanal.Controls.Add(this.button4);
            this.Menupanal.Controls.Add(this.panel3);
            this.Menupanal.Controls.Add(this.button1);
            this.Menupanal.Controls.Add(this.btnlogout);
            this.Menupanal.Controls.Add(this.btn_item);
            this.Menupanal.Controls.Add(this.btn_home);
            this.Menupanal.Controls.Add(this.panel1);
            this.Menupanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanal.Location = new System.Drawing.Point(0, 0);
            this.Menupanal.Name = "Menupanal";
            this.Menupanal.Size = new System.Drawing.Size(216, 749);
            this.Menupanal.TabIndex = 3;
            this.Menupanal.Paint += new System.Windows.Forms.PaintEventHandler(this.Menupanal_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 70);
            this.button4.TabIndex = 15;
            this.button4.Text = "MATIRIALS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btn_additem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 95);
            this.panel3.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Update Items";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete Items";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_additem
            // 
            this.btn_additem.BackColor = System.Drawing.Color.Black;
            this.btn_additem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_additem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_additem.ForeColor = System.Drawing.Color.White;
            this.btn_additem.Location = new System.Drawing.Point(0, 0);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(216, 30);
            this.btn_additem.TabIndex = 13;
            this.btn_additem.Text = "Add Items";
            this.btn_additem.UseVisualStyleBackColor = false;
            this.btn_additem.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_home1
            // 
            this.panel_home1.AutoScroll = true;
            this.panel_home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_home1.Controls.Add(this.label1);
            this.panel_home1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel_home1.Location = new System.Drawing.Point(216, 0);
            this.panel_home1.Name = "panel_home1";
            this.panel_home1.Size = new System.Drawing.Size(1542, 749);
            this.panel_home1.TabIndex = 2;
            // 
            // OrderHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1758, 749);
            this.Controls.Add(this.Menupanal);
            this.Controls.Add(this.panel_home1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Home";
            this.Load += new System.EventHandler(this.OrderHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Menupanal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_home1.ResumeLayout(false);
            this.panel_home1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Menupanal;
        private System.Windows.Forms.Panel panel_home1;
        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}