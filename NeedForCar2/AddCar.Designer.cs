namespace NeedForCar2
{
    partial class AddCar
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
            this.components = new System.ComponentModel.Container();
            this.btn_upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_engine = new System.Windows.Forms.TextBox();
            this.txt_power = new System.Windows.Forms.TextBox();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pic_car = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.carRentalDataSet = new NeedForCar2.CarRentalDataSet();
            this.tblCarTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CarTypeTableAdapter = new NeedForCar2.CarRentalDataSetTableAdapters.tbl_CarTypeTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_license = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_upload.Location = new System.Drawing.Point(30, 836);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(914, 35);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "UPLOAD PICTURE";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(950, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill Out Car Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(956, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 1);
            this.panel1.TabIndex = 3;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(1175, 68);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(320, 36);
            this.lbl_error.TabIndex = 4;
            this.lbl_error.Text = "Fill All Required FIelds (*)";
            this.lbl_error.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1039, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.Location = new System.Drawing.Point(1045, 137);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(340, 35);
            this.txt_Name.TabIndex = 6;
            // 
            // txt_brand
            // 
            this.txt_brand.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brand.ForeColor = System.Drawing.Color.Black;
            this.txt_brand.Location = new System.Drawing.Point(1045, 323);
            this.txt_brand.Multiline = true;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(340, 35);
            this.txt_brand.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1391, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1391, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "*";
            // 
            // txt_engine
            // 
            this.txt_engine.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_engine.ForeColor = System.Drawing.Color.Black;
            this.txt_engine.Location = new System.Drawing.Point(1047, 481);
            this.txt_engine.Multiline = true;
            this.txt_engine.Name = "txt_engine";
            this.txt_engine.Size = new System.Drawing.Size(340, 35);
            this.txt_engine.TabIndex = 12;
            // 
            // txt_power
            // 
            this.txt_power.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_power.ForeColor = System.Drawing.Color.Black;
            this.txt_power.Location = new System.Drawing.Point(1047, 558);
            this.txt_power.Multiline = true;
            this.txt_power.Name = "txt_power";
            this.txt_power.Size = new System.Drawing.Size(340, 35);
            this.txt_power.TabIndex = 14;
            // 
            // txt_speed
            // 
            this.txt_speed.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_speed.ForeColor = System.Drawing.Color.Black;
            this.txt_speed.Location = new System.Drawing.Point(1048, 635);
            this.txt_speed.Multiline = true;
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(340, 35);
            this.txt_speed.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1393, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 36);
            this.label9.TabIndex = 17;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1393, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1394, 635);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1392, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 36);
            this.label12.TabIndex = 22;
            this.label12.Text = "*";
            // 
            // pic_car
            // 
            this.pic_car.BackColor = System.Drawing.Color.White;
            this.pic_car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_car.Location = new System.Drawing.Point(30, 24);
            this.pic_car.Name = "pic_car";
            this.pic_car.Size = new System.Drawing.Size(914, 806);
            this.pic_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_car.TabIndex = 0;
            this.pic_car.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_submit.Location = new System.Drawing.Point(1026, 795);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(391, 35);
            this.btn_submit.TabIndex = 24;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // carRentalDataSet
            // 
            this.carRentalDataSet.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarTypeBindingSource
            // 
            this.tblCarTypeBindingSource.DataMember = "tbl_CarType";
            this.tblCarTypeBindingSource.DataSource = this.carRentalDataSet;
            // 
            // tbl_CarTypeTableAdapter
            // 
            this.tbl_CarTypeTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1391, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 36);
            this.label14.TabIndex = 27;
            this.label14.Text = "*";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.ForeColor = System.Drawing.Color.Black;
            this.txt_model.Location = new System.Drawing.Point(1045, 233);
            this.txt_model.Multiline = true;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(340, 35);
            this.txt_model.TabIndex = 26;
            // 
            // combo_type
            // 
            this.combo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_type.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_type.ForeColor = System.Drawing.Color.Black;
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Location = new System.Drawing.Point(1046, 405);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(340, 34);
            this.combo_type.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(30, 836);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(914, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "UPLOAD PICTURE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(1039, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 26);
            this.label16.TabIndex = 7;
            this.label16.Text = "Car Brand";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(1041, 452);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 26);
            this.label17.TabIndex = 11;
            this.label17.Text = "Engine";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(1041, 529);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 26);
            this.label18.TabIndex = 13;
            this.label18.Text = "Power";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(1043, 606);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 26);
            this.label19.TabIndex = 15;
            this.label19.Text = "0-100 (km/h) (seconds)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(1039, 376);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 26);
            this.label20.TabIndex = 20;
            this.label20.Text = "Car Type";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1026, 795);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(391, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(1039, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 26);
            this.label21.TabIndex = 25;
            this.label21.Text = "Car Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Satoshi Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1393, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // txt_license
            // 
            this.txt_license.Font = new System.Drawing.Font("Satoshi Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_license.ForeColor = System.Drawing.Color.Black;
            this.txt_license.Location = new System.Drawing.Point(1047, 712);
            this.txt_license.Multiline = true;
            this.txt_license.Name = "txt_license";
            this.txt_license.Size = new System.Drawing.Size(340, 35);
            this.txt_license.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Satoshi Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1041, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "License Plate";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_license);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_speed);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_power);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_engine);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pic_car);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddCar";
            this.Size = new System.Drawing.Size(1495, 874);
            this.Load += new System.EventHandler(this.AddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_car;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_engine;
        private System.Windows.Forms.TextBox txt_power;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.BindingSource tblCarTypeBindingSource;
        private CarRentalDataSet carRentalDataSet;
        private CarRentalDataSetTableAdapters.tbl_CarTypeTableAdapter tbl_CarTypeTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_license;
        private System.Windows.Forms.Label label6;
    }
}
