
namespace Employee_Managemant_system
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxhome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDay = new System.Windows.Forms.Label();
            this.labelyear = new System.Windows.Forms.Label();
            this.labelsec = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4321838.jpg");
            this.imageList1.Images.SetKeyName(1, "adult_blur_chocolate_computer_desk_employee_female_598879.jpg");
            this.imageList1.Images.SetKeyName(2, "wp7728133.jpg");
            // 
            // pictureBoxhome
            // 
            this.pictureBoxhome.Location = new System.Drawing.Point(635, 74);
            this.pictureBoxhome.Name = "pictureBoxhome";
            this.pictureBoxhome.Size = new System.Drawing.Size(713, 601);
            this.pictureBoxhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxhome.TabIndex = 0;
            this.pictureBoxhome.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.Green;
            this.labelDay.Location = new System.Drawing.Point(394, 486);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(175, 44);
            this.labelDay.TabIndex = 9;
            this.labelDay.Text = "SUNDAY";
            // 
            // labelyear
            // 
            this.labelyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelyear.ForeColor = System.Drawing.Color.Green;
            this.labelyear.Location = new System.Drawing.Point(110, 486);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(315, 65);
            this.labelyear.TabIndex = 8;
            this.labelyear.Text = "JUNE 25 2020";
            // 
            // labelsec
            // 
            this.labelsec.AutoSize = true;
            this.labelsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsec.ForeColor = System.Drawing.Color.White;
            this.labelsec.Location = new System.Drawing.Point(488, 439);
            this.labelsec.Name = "labelsec";
            this.labelsec.Size = new System.Drawing.Size(47, 32);
            this.labelsec.TabIndex = 7;
            this.labelsec.Text = "22";
            // 
            // labeltime
            // 
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.White;
            this.labeltime.Location = new System.Drawing.Point(123, 355);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(421, 134);
            this.labeltime.TabIndex = 6;
            this.labeltime.Text = "22.22";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1187, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "OV Developers";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(474, 263);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1758, 749);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.labelsec);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.pictureBoxhome);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxhome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.Label labelsec;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}