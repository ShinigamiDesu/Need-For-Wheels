namespace NeedForCar2
{
    partial class Cars
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rent = new System.Windows.Forms.Button();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_power = new System.Windows.Forms.Label();
            this.lbl_engine = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CarID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pic_status = new System.Windows.Forms.PictureBox();
            this.pic_car = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_rent);
            this.panel1.Controls.Add(this.lbl_speed);
            this.panel1.Controls.Add(this.lbl_power);
            this.panel1.Controls.Add(this.lbl_engine);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.lbl_brand);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 98);
            this.panel1.TabIndex = 0;
            // 
            // btn_rent
            // 
            this.btn_rent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_rent.Location = new System.Drawing.Point(260, 3);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(87, 33);
            this.btn_rent.TabIndex = 11;
            this.btn_rent.Text = "Rent";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.Black;
            this.lbl_speed.Location = new System.Drawing.Point(93, 78);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(30, 16);
            this.lbl_speed.TabIndex = 10;
            this.lbl_speed.Text = "3.9s";
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_power.ForeColor = System.Drawing.Color.Black;
            this.lbl_power.Location = new System.Drawing.Point(55, 60);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(110, 16);
            this.lbl_power.TabIndex = 9;
            this.lbl_power.Text = "503HP@6250rpm";
            // 
            // lbl_engine
            // 
            this.lbl_engine.AutoSize = true;
            this.lbl_engine.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_engine.ForeColor = System.Drawing.Color.Black;
            this.lbl_engine.Location = new System.Drawing.Point(60, 40);
            this.lbl_engine.Name = "lbl_engine";
            this.lbl_engine.Size = new System.Drawing.Size(157, 16);
            this.lbl_engine.TabIndex = 8;
            this.lbl_engine.Text = "3.0L Twin Turbo Incline-6";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.ForeColor = System.Drawing.Color.Black;
            this.lbl_model.Location = new System.Drawing.Point(57, 21);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(35, 16);
            this.lbl_model.TabIndex = 7;
            this.lbl_model.Text = "2023";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.Black;
            this.lbl_brand.Location = new System.Drawing.Point(54, 2);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(39, 16);
            this.lbl_brand.TabIndex = 6;
            this.lbl_brand.Text = "BMW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Power :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "0 -100 km/h :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Engine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand :";
            // 
            // lbl_CarID
            // 
            this.lbl_CarID.AutoSize = true;
            this.lbl_CarID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarID.Location = new System.Drawing.Point(326, 3);
            this.lbl_CarID.Name = "lbl_CarID";
            this.lbl_CarID.Size = new System.Drawing.Size(21, 17);
            this.lbl_CarID.TabIndex = 5;
            this.lbl_CarID.Text = "ID";
            this.lbl_CarID.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Satoshi Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(1, 222);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(205, 24);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "M4 Competition Coupé";
            // 
            // pic_status
            // 
            this.pic_status.Image = global::NeedForCar2.Properties.Resources.Green_Circle;
            this.pic_status.Location = new System.Drawing.Point(3, 3);
            this.pic_status.Name = "pic_status";
            this.pic_status.Size = new System.Drawing.Size(31, 30);
            this.pic_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_status.TabIndex = 1;
            this.pic_status.TabStop = false;
            // 
            // pic_car
            // 
            this.pic_car.Image = global::NeedForCar2.Properties.Resources.m4_competition_coupe_pro1;
            this.pic_car.Location = new System.Drawing.Point(40, 3);
            this.pic_car.Name = "pic_car";
            this.pic_car.Size = new System.Drawing.Size(271, 239);
            this.pic_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_car.TabIndex = 6;
            this.pic_car.TabStop = false;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_CarID);
            this.Controls.Add(this.pic_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_car);
            this.Margin = new System.Windows.Forms.Padding(17, 15, 0, 0);
            this.Name = "Cars";
            this.Size = new System.Drawing.Size(350, 350);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_status;
        private System.Windows.Forms.Label lbl_CarID;
        private System.Windows.Forms.PictureBox pic_car;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_engine;
        private System.Windows.Forms.Label lbl_power;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Button btn_rent;
    }
}
