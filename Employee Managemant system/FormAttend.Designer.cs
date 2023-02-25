
namespace Employee_Managemant_system
{
    partial class FormAttend
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_EAid = new Guna.UI.WinForms.GunaTextBox();
            this.cmb_EAattend = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDateTimePickerEA = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btn_EAadd = new System.Windows.Forms.Button();
            this.gunaDataGridViewEA = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_EAupdate = new System.Windows.Forms.Button();
            this.btn_deletesal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewEA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Attends";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // tb_EAid
            // 
            this.tb_EAid.BaseColor = System.Drawing.Color.White;
            this.tb_EAid.BorderColor = System.Drawing.Color.Silver;
            this.tb_EAid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_EAid.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_EAid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_EAid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_EAid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_EAid.ForeColor = System.Drawing.Color.Black;
            this.tb_EAid.Location = new System.Drawing.Point(234, 143);
            this.tb_EAid.Name = "tb_EAid";
            this.tb_EAid.PasswordChar = '\0';
            this.tb_EAid.SelectedText = "";
            this.tb_EAid.Size = new System.Drawing.Size(225, 32);
            this.tb_EAid.TabIndex = 16;
            this.tb_EAid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_EAattend
            // 
            this.cmb_EAattend.BackColor = System.Drawing.Color.Transparent;
            this.cmb_EAattend.BaseColor = System.Drawing.Color.White;
            this.cmb_EAattend.BorderColor = System.Drawing.Color.Silver;
            this.cmb_EAattend.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_EAattend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EAattend.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_EAattend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_EAattend.ForeColor = System.Drawing.Color.Black;
            this.cmb_EAattend.FormattingEnabled = true;
            this.cmb_EAattend.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmb_EAattend.Location = new System.Drawing.Point(234, 242);
            this.cmb_EAattend.Name = "cmb_EAattend";
            this.cmb_EAattend.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb_EAattend.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_EAattend.Size = new System.Drawing.Size(225, 31);
            this.cmb_EAattend.TabIndex = 18;
            // 
            // gunaDateTimePickerEA
            // 
            this.gunaDateTimePickerEA.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerEA.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePickerEA.CustomFormat = null;
            this.gunaDateTimePickerEA.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePickerEA.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerEA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePickerEA.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerEA.Location = new System.Drawing.Point(234, 343);
            this.gunaDateTimePickerEA.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePickerEA.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePickerEA.Name = "gunaDateTimePickerEA";
            this.gunaDateTimePickerEA.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerEA.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerEA.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerEA.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerEA.Size = new System.Drawing.Size(223, 30);
            this.gunaDateTimePickerEA.TabIndex = 19;
            this.gunaDateTimePickerEA.Text = "Wednesday, February 24, 2021";
            this.gunaDateTimePickerEA.Value = new System.DateTime(2021, 2, 24, 22, 10, 2, 419);
            // 
            // btn_EAadd
            // 
            this.btn_EAadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_EAadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EAadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EAadd.ForeColor = System.Drawing.Color.White;
            this.btn_EAadd.Location = new System.Drawing.Point(49, 504);
            this.btn_EAadd.Name = "btn_EAadd";
            this.btn_EAadd.Size = new System.Drawing.Size(139, 49);
            this.btn_EAadd.TabIndex = 20;
            this.btn_EAadd.Text = "ADD";
            this.btn_EAadd.UseVisualStyleBackColor = false;
            this.btn_EAadd.Click += new System.EventHandler(this.btn_EAadd_Click);
            // 
            // gunaDataGridViewEA
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridViewEA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewEA.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridViewEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewEA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewEA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewEA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewEA.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewEA.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewEA.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewEA.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridViewEA.Location = new System.Drawing.Point(558, 86);
            this.gunaDataGridViewEA.Name = "gunaDataGridViewEA";
            this.gunaDataGridViewEA.RowHeadersVisible = false;
            this.gunaDataGridViewEA.RowHeadersWidth = 51;
            this.gunaDataGridViewEA.RowTemplate.Height = 24;
            this.gunaDataGridViewEA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewEA.Size = new System.Drawing.Size(720, 560);
            this.gunaDataGridViewEA.TabIndex = 22;
            this.gunaDataGridViewEA.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.gunaDataGridViewEA.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridViewEA.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewEA.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewEA.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewEA.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewEA.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridViewEA.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridViewEA.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.gunaDataGridViewEA.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewEA.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewEA.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewEA.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewEA.ThemeStyle.HeaderStyle.Height = 20;
            this.gunaDataGridViewEA.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.gunaDataGridViewEA.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewEA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridViewEA_CellContentClick);
            // 
            // btn_EAupdate
            // 
            this.btn_EAupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_EAupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EAupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EAupdate.ForeColor = System.Drawing.Color.White;
            this.btn_EAupdate.Location = new System.Drawing.Point(222, 504);
            this.btn_EAupdate.Name = "btn_EAupdate";
            this.btn_EAupdate.Size = new System.Drawing.Size(139, 49);
            this.btn_EAupdate.TabIndex = 23;
            this.btn_EAupdate.Text = "UPDATE";
            this.btn_EAupdate.UseVisualStyleBackColor = false;
            this.btn_EAupdate.Click += new System.EventHandler(this.btn_EAupdate_Click);
            // 
            // btn_deletesal
            // 
            this.btn_deletesal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_deletesal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deletesal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletesal.ForeColor = System.Drawing.Color.White;
            this.btn_deletesal.Location = new System.Drawing.Point(393, 504);
            this.btn_deletesal.Name = "btn_deletesal";
            this.btn_deletesal.Size = new System.Drawing.Size(139, 49);
            this.btn_deletesal.TabIndex = 24;
            this.btn_deletesal.Text = "DELETE";
            this.btn_deletesal.UseVisualStyleBackColor = false;
            this.btn_deletesal.Click += new System.EventHandler(this.btn_deletesal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Attendance";
            // 
            // FormAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1534, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deletesal);
            this.Controls.Add(this.btn_EAupdate);
            this.Controls.Add(this.gunaDataGridViewEA);
            this.Controls.Add(this.btn_EAadd);
            this.Controls.Add(this.gunaDateTimePickerEA);
            this.Controls.Add(this.cmb_EAattend);
            this.Controls.Add(this.tb_EAid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAttend";
            this.Text = "FormAttend";
            this.Load += new System.EventHandler(this.FormAttend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox tb_EAid;
        private Guna.UI.WinForms.GunaComboBox cmb_EAattend;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePickerEA;
        private System.Windows.Forms.Button btn_EAadd;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewEA;
        private System.Windows.Forms.Button btn_EAupdate;
        private System.Windows.Forms.Button btn_deletesal;
        private System.Windows.Forms.Label label2;
    }
}