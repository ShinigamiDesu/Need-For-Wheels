namespace NeedForCar2
{
    partial class ViewCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ln = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_FN = new System.Windows.Forms.TextBox();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.CusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.pic_add = new System.Windows.Forms.PictureBox();
            this.pic_phone = new System.Windows.Forms.PictureBox();
            this.pic_ln = new System.Windows.Forms.PictureBox();
            this.pic_FN = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(328, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 5);
            this.panel2.TabIndex = 16;
            // 
            // txt_ln
            // 
            this.txt_ln.BackColor = System.Drawing.Color.Black;
            this.txt_ln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ln.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ln.ForeColor = System.Drawing.Color.Gray;
            this.txt_ln.Location = new System.Drawing.Point(325, 19);
            this.txt_ln.Multiline = true;
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.Size = new System.Drawing.Size(214, 33);
            this.txt_ln.TabIndex = 17;
            this.txt_ln.Text = "Search Last Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(34, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 5);
            this.panel3.TabIndex = 13;
            // 
            // txt_FN
            // 
            this.txt_FN.BackColor = System.Drawing.Color.Black;
            this.txt_FN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FN.ForeColor = System.Drawing.Color.Gray;
            this.txt_FN.Location = new System.Drawing.Point(31, 20);
            this.txt_FN.Multiline = true;
            this.txt_FN.Name = "txt_FN";
            this.txt_FN.Size = new System.Drawing.Size(214, 33);
            this.txt_FN.TabIndex = 14;
            this.txt_FN.Text = "Search First Name";
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.White;
            this.data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Satoshi Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusID,
            this.FN,
            this.LN,
            this.PhoneNo,
            this.License});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid.DefaultCellStyle = dataGridViewCellStyle20;
            this.data_grid.Location = new System.Drawing.Point(-42, 68);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.data_grid.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.data_grid.RowTemplate.Height = 40;
            this.data_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(1534, 803);
            this.data_grid.TabIndex = 12;
            // 
            // CusID
            // 
            this.CusID.HeaderText = "CusID";
            this.CusID.Name = "CusID";
            this.CusID.ReadOnly = true;
            this.CusID.Width = 5;
            // 
            // FN
            // 
            this.FN.HeaderText = "Customer First Name";
            this.FN.Name = "FN";
            this.FN.ReadOnly = true;
            this.FN.Width = 350;
            // 
            // LN
            // 
            this.LN.HeaderText = "Customer Last Name";
            this.LN.Name = "LN";
            this.LN.ReadOnly = true;
            this.LN.Width = 350;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone Number";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Width = 350;
            // 
            // License
            // 
            this.License.HeaderText = "License ID";
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Width = 440;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(628, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 5);
            this.panel1.TabIndex = 19;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.Black;
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Gray;
            this.txt_phone.Location = new System.Drawing.Point(625, 19);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(214, 33);
            this.txt_phone.TabIndex = 20;
            this.txt_phone.Text = "Search Phone No";
            // 
            // pic_add
            // 
            this.pic_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_add.Image = global::NeedForCar2.Properties.Resources.Add_12;
            this.pic_add.Location = new System.Drawing.Point(1441, 14);
            this.pic_add.Name = "pic_add";
            this.pic_add.Size = new System.Drawing.Size(40, 40);
            this.pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_add.TabIndex = 22;
            this.pic_add.TabStop = false;
            this.pic_add.Click += new System.EventHandler(this.pic_add_Click);
            // 
            // pic_phone
            // 
            this.pic_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_phone.Image = global::NeedForCar2.Properties.Resources.Search1;
            this.pic_phone.Location = new System.Drawing.Point(842, 13);
            this.pic_phone.Name = "pic_phone";
            this.pic_phone.Size = new System.Drawing.Size(40, 40);
            this.pic_phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_phone.TabIndex = 21;
            this.pic_phone.TabStop = false;
            this.pic_phone.Click += new System.EventHandler(this.pic_phone_Click);
            // 
            // pic_ln
            // 
            this.pic_ln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ln.Image = global::NeedForCar2.Properties.Resources.Search1;
            this.pic_ln.Location = new System.Drawing.Point(542, 13);
            this.pic_ln.Name = "pic_ln";
            this.pic_ln.Size = new System.Drawing.Size(40, 40);
            this.pic_ln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ln.TabIndex = 18;
            this.pic_ln.TabStop = false;
            this.pic_ln.Click += new System.EventHandler(this.pic_ln_Click);
            // 
            // pic_FN
            // 
            this.pic_FN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_FN.Image = global::NeedForCar2.Properties.Resources.Search1;
            this.pic_FN.Location = new System.Drawing.Point(248, 14);
            this.pic_FN.Name = "pic_FN";
            this.pic_FN.Size = new System.Drawing.Size(40, 40);
            this.pic_FN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FN.TabIndex = 15;
            this.pic_FN.TabStop = false;
            this.pic_FN.Click += new System.EventHandler(this.pic_FN_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Satoshi Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(928, 25);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(98, 29);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pic_add);
            this.Controls.Add(this.pic_phone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.pic_ln);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_ln);
            this.Controls.Add(this.pic_FN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_FN);
            this.Controls.Add(this.data_grid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewCustomers";
            this.Size = new System.Drawing.Size(1495, 874);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ln;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ln;
        private System.Windows.Forms.PictureBox pic_FN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_FN;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.PictureBox pic_phone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.PictureBox pic_add;
        private System.Windows.Forms.Button btn_reset;
    }
}
