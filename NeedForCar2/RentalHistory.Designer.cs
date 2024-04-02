namespace NeedForCar2
{
    partial class RentalHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.rentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.White;
            this.data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Satoshi Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentid,
            this.FN,
            this.LN,
            this.carName,
            this.License,
            this.RentDate,
            this.ReturnDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid.Location = new System.Drawing.Point(-45, 64);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.data_grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid.RowTemplate.Height = 40;
            this.data_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(1540, 810);
            this.data_grid.TabIndex = 13;
            // 
            // rentid
            // 
            this.rentid.HeaderText = "rentid";
            this.rentid.Name = "rentid";
            this.rentid.ReadOnly = true;
            this.rentid.Width = 5;
            // 
            // FN
            // 
            this.FN.HeaderText = "First Name";
            this.FN.Name = "FN";
            this.FN.ReadOnly = true;
            this.FN.Width = 215;
            // 
            // LN
            // 
            this.LN.HeaderText = "Last Name";
            this.LN.Name = "LN";
            this.LN.ReadOnly = true;
            this.LN.Width = 215;
            // 
            // carName
            // 
            this.carName.HeaderText = "Car Name";
            this.carName.Name = "carName";
            this.carName.ReadOnly = true;
            this.carName.Width = 350;
            // 
            // License
            // 
            this.License.HeaderText = "License Plate";
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Width = 200;
            // 
            // RentDate
            // 
            this.RentDate.HeaderText = "Rent Date";
            this.RentDate.Name = "RentDate";
            this.RentDate.ReadOnly = true;
            this.RentDate.Width = 250;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 262;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 65);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Satoshi Light", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental Data";
            // 
            // RentalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_grid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RentalHistory";
            this.Size = new System.Drawing.Size(1495, 874);
            this.Load += new System.EventHandler(this.RentalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN;
        private System.Windows.Forms.DataGridViewTextBoxColumn carName;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
