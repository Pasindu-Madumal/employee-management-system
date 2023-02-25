
namespace Employee_Managemant_system
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.myphoto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBar1.IdleOffset = 10;
            this.gunaCircleProgressBar1.IdleThickness = 10;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(681, 340);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.gunaCircleProgressBar1.ProgressOffset = 10;
            this.gunaCircleProgressBar1.ProgressThickness = 10;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(107, 101);
            this.gunaCircleProgressBar1.TabIndex = 1;
            // 
            // myphoto
            // 
            this.myphoto.BaseColor = System.Drawing.Color.White;
            this.myphoto.Image = ((System.Drawing.Image)(resources.GetObject("myphoto.Image")));
            this.myphoto.Location = new System.Drawing.Point(145, 12);
            this.myphoto.Name = "myphoto";
            this.myphoto.Size = new System.Drawing.Size(530, 338);
            this.myphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myphoto.TabIndex = 0;
            this.myphoto.TabStop = false;
            this.myphoto.UseTransfarantBackground = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "OV Developers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myphoto);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private Guna.UI.WinForms.GunaCirclePictureBox myphoto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

