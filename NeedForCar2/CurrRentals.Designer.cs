namespace NeedForCar2
{
    partial class CurrRentals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.rentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pic_ln = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ln = new System.Windows.Forms.TextBox();
            this.pic_phone = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_phone)).BeginInit();
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Satoshi Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentid,
            this.CusID,
            this.CarID,
            this.FN,
            this.LN,
            this.PhoneNo,
            this.carName,
            this.carBrand,
            this.update});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid.DefaultCellStyle = dataGridViewCellStyle15;
            this.data_grid.Location = new System.Drawing.Point(-56, 46);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.data_grid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.data_grid.RowTemplate.Height = 40;
            this.data_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(1546, 803);
            this.data_grid.TabIndex = 0;
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // rentid
            // 
            this.rentid.HeaderText = "";
            this.rentid.Name = "rentid";
            this.rentid.ReadOnly = true;
            this.rentid.Width = 5;
            // 
            // CusID
            // 
            this.CusID.HeaderText = "CusID";
            this.CusID.Name = "CusID";
            this.CusID.ReadOnly = true;
            this.CusID.Width = 5;
            // 
            // CarID
            // 
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.Width = 5;
            // 
            // FN
            // 
            this.FN.HeaderText = "Customer First Name";
            this.FN.Name = "FN";
            this.FN.ReadOnly = true;
            this.FN.Width = 300;
            // 
            // LN
            // 
            this.LN.HeaderText = "Customer Last Name";
            this.LN.Name = "LN";
            this.LN.ReadOnly = true;
            this.LN.Width = 300;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone Number";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Width = 250;
            // 
            // carName
            // 
            this.carName.HeaderText = "Car Name";
            this.carName.Name = "carName";
            this.carName.ReadOnly = true;
            this.carName.Width = 300;
            // 
            // carBrand
            // 
            this.carBrand.HeaderText = "Car Brand";
            this.carBrand.Name = "carBrand";
            this.carBrand.ReadOnly = true;
            this.carBrand.Width = 220;
            // 
            // update
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.update.DefaultCellStyle = dataGridViewCellStyle14;
            this.update.HeaderText = "";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Text = "Update";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 126;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.pic_ln);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_ln);
            this.panel1.Controls.Add(this.pic_phone);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 47);
            this.panel1.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Satoshi Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(1391, 10);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(98, 29);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // pic_ln
            // 
            this.pic_ln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ln.Image = global::NeedForCar2.Properties.Resources.Search1;
            this.pic_ln.Location = new System.Drawing.Point(517, 0);
            this.pic_ln.Name = "pic_ln";
            this.pic_ln.Size = new System.Drawing.Size(40, 40);
            this.pic_ln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ln.TabIndex = 11;
            this.pic_ln.TabStop = false;
            this.pic_ln.Click += new System.EventHandler(this.pic_ln_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(303, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 5);
            this.panel2.TabIndex = 9;
            // 
            // txt_ln
            // 
            this.txt_ln.BackColor = System.Drawing.Color.Black;
            this.txt_ln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ln.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ln.ForeColor = System.Drawing.Color.Gray;
            this.txt_ln.Location = new System.Drawing.Point(300, 6);
            this.txt_ln.Multiline = true;
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.Size = new System.Drawing.Size(214, 33);
            this.txt_ln.TabIndex = 10;
            this.txt_ln.Text = "Search Last Name";
            // 
            // pic_phone
            // 
            this.pic_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_phone.Image = global::NeedForCar2.Properties.Resources.Search1;
            this.pic_phone.Location = new System.Drawing.Point(223, 1);
            this.pic_phone.Name = "pic_phone";
            this.pic_phone.Size = new System.Drawing.Size(40, 40);
            this.pic_phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_phone.TabIndex = 8;
            this.pic_phone.TabStop = false;
            this.pic_phone.Click += new System.EventHandler(this.pic_phone_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(9, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 5);
            this.panel3.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.Black;
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Gray;
            this.txt_phone.Location = new System.Drawing.Point(6, 7);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(214, 33);
            this.txt_phone.TabIndex = 7;
            this.txt_phone.Text = "Search Phone";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Satoshi Light", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Black;
            this.lbl_error.Location = new System.Drawing.Point(436, 413);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(632, 46);
            this.lbl_error.TabIndex = 2;
            this.lbl_error.Text = "No Car is being Rented at the Moment.";
            // 
            // CurrRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_grid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CurrRentals";
            this.Size = new System.Drawing.Size(1495, 874);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_phone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_phone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.PictureBox pic_ln;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn carName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrand;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_error;
    }
}
