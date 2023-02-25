
namespace Employee_Managemant_system
{
    partial class metirail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_deletem = new System.Windows.Forms.Button();
            this.btn_editm = new System.Windows.Forms.Button();
            this.btn_addm = new System.Windows.Forms.Button();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.tb_mname = new Guna.UI.WinForms.GunaTextBox();
            this.tb_mq = new Guna.UI.WinForms.GunaTextBox();
            this.tb_mcode = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tb_mid = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletem
            // 
            this.btn_deletem.AutoSize = true;
            this.btn_deletem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_deletem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deletem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletem.ForeColor = System.Drawing.Color.White;
            this.btn_deletem.Location = new System.Drawing.Point(329, 483);
            this.btn_deletem.Name = "btn_deletem";
            this.btn_deletem.Size = new System.Drawing.Size(116, 51);
            this.btn_deletem.TabIndex = 39;
            this.btn_deletem.Text = "Delete";
            this.btn_deletem.UseVisualStyleBackColor = false;
            this.btn_deletem.Click += new System.EventHandler(this.btn_deletem_Click);
            // 
            // btn_editm
            // 
            this.btn_editm.AutoSize = true;
            this.btn_editm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_editm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editm.ForeColor = System.Drawing.Color.White;
            this.btn_editm.Location = new System.Drawing.Point(176, 483);
            this.btn_editm.Name = "btn_editm";
            this.btn_editm.Size = new System.Drawing.Size(116, 51);
            this.btn_editm.TabIndex = 38;
            this.btn_editm.Text = "Edit";
            this.btn_editm.UseVisualStyleBackColor = false;
            this.btn_editm.Click += new System.EventHandler(this.btn_editm_Click);
            // 
            // btn_addm
            // 
            this.btn_addm.AutoSize = true;
            this.btn_addm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_addm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addm.ForeColor = System.Drawing.Color.White;
            this.btn_addm.Location = new System.Drawing.Point(28, 483);
            this.btn_addm.Name = "btn_addm";
            this.btn_addm.Size = new System.Drawing.Size(116, 51);
            this.btn_addm.TabIndex = 37;
            this.btn_addm.Text = "Add";
            this.btn_addm.UseVisualStyleBackColor = false;
            this.btn_addm.Click += new System.EventHandler(this.btn_addm_Click);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridView1.Location = new System.Drawing.Point(451, 86);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1060, 560);
            this.gunaDataGridView1.TabIndex = 36;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // tb_mname
            // 
            this.tb_mname.BaseColor = System.Drawing.Color.White;
            this.tb_mname.BorderColor = System.Drawing.Color.Silver;
            this.tb_mname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mname.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_mname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_mname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_mname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_mname.ForeColor = System.Drawing.Color.Black;
            this.tb_mname.Location = new System.Drawing.Point(220, 283);
            this.tb_mname.Name = "tb_mname";
            this.tb_mname.PasswordChar = '\0';
            this.tb_mname.SelectedText = "";
            this.tb_mname.Size = new System.Drawing.Size(225, 32);
            this.tb_mname.TabIndex = 32;
            // 
            // tb_mq
            // 
            this.tb_mq.BaseColor = System.Drawing.Color.White;
            this.tb_mq.BorderColor = System.Drawing.Color.Silver;
            this.tb_mq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mq.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_mq.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_mq.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_mq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_mq.ForeColor = System.Drawing.Color.Black;
            this.tb_mq.Location = new System.Drawing.Point(30, 405);
            this.tb_mq.Name = "tb_mq";
            this.tb_mq.PasswordChar = '\0';
            this.tb_mq.SelectedText = "";
            this.tb_mq.Size = new System.Drawing.Size(160, 32);
            this.tb_mq.TabIndex = 31;
            // 
            // tb_mcode
            // 
            this.tb_mcode.BaseColor = System.Drawing.Color.White;
            this.tb_mcode.BorderColor = System.Drawing.Color.Silver;
            this.tb_mcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mcode.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_mcode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_mcode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_mcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_mcode.ForeColor = System.Drawing.Color.Black;
            this.tb_mcode.Location = new System.Drawing.Point(220, 405);
            this.tb_mcode.Name = "tb_mcode";
            this.tb_mcode.PasswordChar = '\0';
            this.tb_mcode.SelectedText = "";
            this.tb_mcode.Size = new System.Drawing.Size(225, 32);
            this.tb_mcode.TabIndex = 30;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(218, 260);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(104, 20);
            this.gunaLabel8.TabIndex = 29;
            this.gunaLabel8.Text = "Matirial Name";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(26, 382);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(65, 20);
            this.gunaLabel7.TabIndex = 28;
            this.gunaLabel7.Text = "Quantity";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(216, 382);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(99, 20);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "Matirial Code";
            // 
            // tb_mid
            // 
            this.tb_mid.BaseColor = System.Drawing.Color.White;
            this.tb_mid.BorderColor = System.Drawing.Color.Silver;
            this.tb_mid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mid.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_mid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_mid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_mid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_mid.ForeColor = System.Drawing.Color.Black;
            this.tb_mid.Location = new System.Drawing.Point(30, 283);
            this.tb_mid.Name = "tb_mid";
            this.tb_mid.PasswordChar = '\0';
            this.tb_mid.SelectedText = "";
            this.tb_mid.Size = new System.Drawing.Size(160, 32);
            this.tb_mid.TabIndex = 22;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(26, 260);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 20);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Matirial Id";
            // 
            // metirail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1534, 733);
            this.Controls.Add(this.btn_deletem);
            this.Controls.Add(this.btn_editm);
            this.Controls.Add(this.btn_addm);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.tb_mname);
            this.Controls.Add(this.tb_mq);
            this.Controls.Add(this.tb_mcode);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.tb_mid);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "metirail";
            this.Text = "metirail";
            this.Load += new System.EventHandler(this.metirail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deletem;
        private System.Windows.Forms.Button btn_editm;
        private System.Windows.Forms.Button btn_addm;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaTextBox tb_mname;
        private Guna.UI.WinForms.GunaTextBox tb_mq;
        private Guna.UI.WinForms.GunaTextBox tb_mcode;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox tb_mid;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}