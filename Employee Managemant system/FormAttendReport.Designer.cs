
namespace Employee_Managemant_system
{
    partial class FormAttendReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendReport));
            this.date_Attendrep = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btn_SALRE = new System.Windows.Forms.Button();
            this.gunaDataGridViewAttre = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewAttre)).BeginInit();
            this.SuspendLayout();
            // 
            // date_Attendrep
            // 
            this.date_Attendrep.BaseColor = System.Drawing.Color.White;
            this.date_Attendrep.BorderColor = System.Drawing.Color.Silver;
            this.date_Attendrep.CustomFormat = null;
            this.date_Attendrep.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_Attendrep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_Attendrep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_Attendrep.ForeColor = System.Drawing.Color.Black;
            this.date_Attendrep.Location = new System.Drawing.Point(379, 76);
            this.date_Attendrep.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_Attendrep.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_Attendrep.Name = "date_Attendrep";
            this.date_Attendrep.OnHoverBaseColor = System.Drawing.Color.White;
            this.date_Attendrep.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_Attendrep.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_Attendrep.OnPressedColor = System.Drawing.Color.Black;
            this.date_Attendrep.Size = new System.Drawing.Size(223, 30);
            this.date_Attendrep.TabIndex = 0;
            this.date_Attendrep.Text = "Thursday, February 25, 2021";
            this.date_Attendrep.Value = new System.DateTime(2021, 2, 25, 16, 6, 55, 404);
            // 
            // btn_SALRE
            // 
            this.btn_SALRE.AutoSize = true;
            this.btn_SALRE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_SALRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SALRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SALRE.ForeColor = System.Drawing.Color.White;
            this.btn_SALRE.Location = new System.Drawing.Point(645, 76);
            this.btn_SALRE.Name = "btn_SALRE";
            this.btn_SALRE.Size = new System.Drawing.Size(170, 35);
            this.btn_SALRE.TabIndex = 23;
            this.btn_SALRE.Text = "GENARATE";
            this.btn_SALRE.UseVisualStyleBackColor = false;
            this.btn_SALRE.Click += new System.EventHandler(this.btn_SALRE_Click);
            // 
            // gunaDataGridViewAttre
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridViewAttre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewAttre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewAttre.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridViewAttre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewAttre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewAttre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewAttre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewAttre.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewAttre.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewAttre.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewAttre.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridViewAttre.Location = new System.Drawing.Point(12, 137);
            this.gunaDataGridViewAttre.Name = "gunaDataGridViewAttre";
            this.gunaDataGridViewAttre.RowHeadersVisible = false;
            this.gunaDataGridViewAttre.RowHeadersWidth = 51;
            this.gunaDataGridViewAttre.RowTemplate.Height = 24;
            this.gunaDataGridViewAttre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewAttre.Size = new System.Drawing.Size(1299, 568);
            this.gunaDataGridViewAttre.TabIndex = 24;
            this.gunaDataGridViewAttre.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.gunaDataGridViewAttre.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridViewAttre.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewAttre.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewAttre.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewAttre.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewAttre.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridViewAttre.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridViewAttre.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.gunaDataGridViewAttre.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewAttre.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewAttre.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewAttre.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewAttre.ThemeStyle.HeaderStyle.Height = 20;
            this.gunaDataGridViewAttre.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.gunaDataGridViewAttre.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Attendance Report";
            // 
            // btn_print
            // 
            this.btn_print.AutoSize = true;
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1086, 25);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(116, 51);
            this.btn_print.TabIndex = 37;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAttendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1534, 733);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaDataGridViewAttre);
            this.Controls.Add(this.btn_SALRE);
            this.Controls.Add(this.date_Attendrep);
            this.Name = "FormAttendReport";
            this.Text = "FormAttendReport";
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewAttre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker date_Attendrep;
        private System.Windows.Forms.Button btn_SALRE;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewAttre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}