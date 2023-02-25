
namespace Employee_Managemant_system
{
    partial class vieworder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vieworder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_view = new System.Windows.Forms.Button();
            this.gunaDataGridVieworde = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_d = new System.Windows.Forms.ComboBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridVieworde)).BeginInit();
            this.SuspendLayout();
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
            // btn_view
            // 
            this.btn_view.AutoSize = true;
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(907, 57);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(170, 35);
            this.btn_view.TabIndex = 39;
            this.btn_view.Text = "Edit";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // gunaDataGridVieworde
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridVieworde.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridVieworde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridVieworde.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridVieworde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridVieworde.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridVieworde.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridVieworde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridVieworde.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridVieworde.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridVieworde.EnableHeadersVisualStyles = false;
            this.gunaDataGridVieworde.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridVieworde.Location = new System.Drawing.Point(22, 108);
            this.gunaDataGridVieworde.Name = "gunaDataGridVieworde";
            this.gunaDataGridVieworde.RowHeadersVisible = false;
            this.gunaDataGridVieworde.RowHeadersWidth = 51;
            this.gunaDataGridVieworde.RowTemplate.Height = 24;
            this.gunaDataGridVieworde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridVieworde.Size = new System.Drawing.Size(1299, 568);
            this.gunaDataGridVieworde.TabIndex = 40;
            this.gunaDataGridVieworde.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.gunaDataGridVieworde.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridVieworde.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridVieworde.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridVieworde.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridVieworde.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridVieworde.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.gunaDataGridVieworde.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.gunaDataGridVieworde.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.gunaDataGridVieworde.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridVieworde.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridVieworde.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridVieworde.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridVieworde.ThemeStyle.HeaderStyle.Height = 20;
            this.gunaDataGridVieworde.ThemeStyle.ReadOnly = false;
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.gunaDataGridVieworde.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDataGridVieworde.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridVieworde_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-47, -22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Attendance Report";
            // 
            // cmb_d
            // 
            this.cmb_d.FormattingEnabled = true;
            this.cmb_d.Items.AddRange(new object[] {
            "Pending",
            "Delivered"});
            this.cmb_d.Location = new System.Drawing.Point(601, 57);
            this.cmb_d.Name = "cmb_d";
            this.cmb_d.Size = new System.Drawing.Size(237, 24);
            this.cmb_d.TabIndex = 42;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(353, 57);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(155, 22);
            this.tb_id.TabIndex = 43;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(258, 57);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(66, 20);
            this.gunaLabel7.TabIndex = 44;
            this.gunaLabel7.Text = "Order ID";
            // 
            // vieworder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1534, 733);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.cmb_d);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaDataGridVieworde);
            this.Controls.Add(this.btn_view);
            this.Name = "vieworder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vieworder";
            this.Load += new System.EventHandler(this.vieworder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridVieworde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_view;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridVieworde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_d;
        private System.Windows.Forms.TextBox tb_id;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}