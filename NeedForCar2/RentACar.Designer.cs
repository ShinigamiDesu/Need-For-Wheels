namespace NeedForCar2
{
    partial class RentACar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_rent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Plate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_License = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_carName = new System.Windows.Forms.Label();
            this.pic_car = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.CusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_error);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_rent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Plate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_License);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_LN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_FN);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pic_car);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 380);
            this.panel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(564, 311);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(151, 35);
            this.btn_Clear.TabIndex = 26;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_rent
            // 
            this.btn_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_rent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rent.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rent.ForeColor = System.Drawing.Color.White;
            this.btn_rent.Location = new System.Drawing.Point(989, 151);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(391, 35);
            this.btn_rent.TabIndex = 25;
            this.btn_rent.Text = "Rent";
            this.btn_rent.UseVisualStyleBackColor = false;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(531, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Car License Plate";
            // 
            // txt_Plate
            // 
            this.txt_Plate.BackColor = System.Drawing.Color.White;
            this.txt_Plate.Enabled = false;
            this.txt_Plate.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Plate.ForeColor = System.Drawing.Color.Black;
            this.txt_Plate.Location = new System.Drawing.Point(536, 249);
            this.txt_Plate.Multiline = true;
            this.txt_Plate.Name = "txt_Plate";
            this.txt_Plate.ReadOnly = true;
            this.txt_Plate.Size = new System.Drawing.Size(202, 31);
            this.txt_Plate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(531, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "License Identification";
            // 
            // txt_License
            // 
            this.txt_License.BackColor = System.Drawing.Color.White;
            this.txt_License.Enabled = false;
            this.txt_License.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_License.ForeColor = System.Drawing.Color.Black;
            this.txt_License.Location = new System.Drawing.Point(536, 177);
            this.txt_License.Multiline = true;
            this.txt_License.Name = "txt_License";
            this.txt_License.ReadOnly = true;
            this.txt_License.Size = new System.Drawing.Size(202, 31);
            this.txt_License.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(531, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // txt_LN
            // 
            this.txt_LN.BackColor = System.Drawing.Color.White;
            this.txt_LN.Enabled = false;
            this.txt_LN.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LN.ForeColor = System.Drawing.Color.Black;
            this.txt_LN.Location = new System.Drawing.Point(536, 110);
            this.txt_LN.Multiline = true;
            this.txt_LN.Name = "txt_LN";
            this.txt_LN.ReadOnly = true;
            this.txt_LN.Size = new System.Drawing.Size(202, 31);
            this.txt_LN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(531, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // txt_FN
            // 
            this.txt_FN.BackColor = System.Drawing.Color.White;
            this.txt_FN.Enabled = false;
            this.txt_FN.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FN.ForeColor = System.Drawing.Color.Black;
            this.txt_FN.Location = new System.Drawing.Point(536, 43);
            this.txt_FN.Multiline = true;
            this.txt_FN.Name = "txt_FN";
            this.txt_FN.ReadOnly = true;
            this.txt_FN.Size = new System.Drawing.Size(202, 31);
            this.txt_FN.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lbl_carName);
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 63);
            this.panel2.TabIndex = 1;
            // 
            // lbl_carName
            // 
            this.lbl_carName.AutoSize = true;
            this.lbl_carName.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carName.ForeColor = System.Drawing.Color.Black;
            this.lbl_carName.Location = new System.Drawing.Point(3, 18);
            this.lbl_carName.Name = "lbl_carName";
            this.lbl_carName.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.lbl_carName.Size = new System.Drawing.Size(282, 26);
            this.lbl_carName.TabIndex = 0;
            this.lbl_carName.Text = "M4 M Competition";
            // 
            // pic_car
            // 
            this.pic_car.Image = global::NeedForCar2.Properties.Resources.m4_competition_coupe_pro;
            this.pic_car.Location = new System.Drawing.Point(-1, 3);
            this.pic_car.Name = "pic_car";
            this.pic_car.Size = new System.Drawing.Size(418, 309);
            this.pic_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_car.TabIndex = 0;
            this.pic_car.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1495, 70);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(681, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select a Customer";
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.White;
            this.data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Satoshi Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusID,
            this.FN,
            this.LN,
            this.PhoneNo,
            this.License});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.data_grid.Location = new System.Drawing.Point(-46, 447);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.data_grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.data_grid.RowTemplate.Height = 40;
            this.data_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(1541, 424);
            this.data_grid.TabIndex = 13;
            this.data_grid.Click += new System.EventHandler(this.data_grid_Click);
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
            this.FN.Width = 370;
            // 
            // LN
            // 
            this.LN.HeaderText = "Customer Last Name";
            this.LN.Name = "LN";
            this.LN.ReadOnly = true;
            this.LN.Width = 370;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone Number";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Width = 355;
            // 
            // License
            // 
            this.License.HeaderText = "License ID";
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Width = 400;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(1107, 43);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(180, 26);
            this.lbl_error.TabIndex = 27;
            this.lbl_error.Text = "Select A Customer";
            this.lbl_error.Visible = false;
            // 
            // RentACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RentACar";
            this.Size = new System.Drawing.Size(1495, 874);
            this.Load += new System.EventHandler(this.RentACar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_car;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_carName;
        private System.Windows.Forms.TextBox txt_FN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_License;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Plate;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_error;
    }
}
