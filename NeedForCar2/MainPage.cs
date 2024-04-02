using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedForCar2
{
    public partial class MainPage : Form
    {
        DataIO dataIO = new DataIO();
        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_brand_Click(object sender, EventArgs e)
        {
            if(txt_brand.Text == "Search Brand") 
            {
                txt_brand.Enabled = true;
                txt_brand.Text = "";
                txt_brand.ForeColor = Color.White;
            }
            
        }

        public void generateCarsWithStatus(DataTable dt)
        {
            flow_main.Controls.Clear();
            if (dt != null)
            {
                Cars[] listItems = new Cars[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new Cars(this);
                        // Adding The Car Picture
                        MemoryStream ms = new MemoryStream((byte[])row["car_ImgValue"]);
                        listItems[i].Pic = new Bitmap(ms);
                        // Adding Car ID
                        listItems[i].CarID = row["CarID"].ToString();
                        // Adding Car Name
                        listItems[i].CarName = row["car_Name"].ToString();
                        // Adding Car Model
                        listItems[i].CarModel = row["car_Model"].ToString();
                        // Adding Car Brand
                        listItems[i].CarBrand = row["car_Brand"].ToString();
                        // Adding Car Engine
                        listItems[i].Engine = row["car_Engine"].ToString();
                        // Adding Car Power
                        listItems[i].Power = row["car_Power"].ToString();
                        // Adding Car Speed
                        listItems[i].Speed = row["car_Speed"].ToString() + "s";
                        // Adding Car PLate
                        listItems[i].Plate = row["car_LicensePlate"].ToString();
                        if (row["car_Rent_Status"].ToString() == "1")
                        {
                            listItems[i].carStatus = pic_red.Image;
                            listItems[i].SetRentButtonVisibility(false);
                        }
                        else
                        {
                            listItems[i].carStatus = pic_green.Image;
                            listItems[i].SetRentButtonVisibility(true);
                        }
                        flow_main.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void generateAllCars()
        {
            DataTable dt = dataIO.getAllCars();
            generateCarsWithStatus(dt);
        }

        public void generateAvailableCars()
        {
            DataTable dt = dataIO.getAllAvailableCars();
            flow_main.Controls.Clear();
            if (dt != null)
            {
                Cars[] listItems = new Cars[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new Cars(this);
                        // Adding The Car Picture
                        MemoryStream ms = new MemoryStream((byte[])row["car_ImgValue"]);
                        listItems[i].Pic = new Bitmap(ms);
                        // Adding Car ID
                        listItems[i].CarID = row["CarID"].ToString();
                        // Adding Car Name
                        listItems[i].CarName = row["car_Name"].ToString();
                        // Adding Car Model
                        listItems[i].CarModel = row["car_Model"].ToString();
                        // Adding Car Brand
                        listItems[i].CarBrand = row["car_Brand"].ToString();
                        // Adding Car Engine
                        listItems[i].Engine = row["car_Engine"].ToString();
                        // Adding Car Power
                        listItems[i].Power = row["car_Power"].ToString();
                        // Adding Car Speed
                        listItems[i].Speed = row["car_Speed"].ToString() + "s";
                        // Adding Car PLate
                        listItems[i].Plate = row["car_LicensePlate"].ToString();
                        // Adding the Rent button
                        listItems[i].SetRentButtonVisibility(true);
                        // Adding Color Green
                        listItems[i].carStatus = pic_green.Image;
                        flow_main.Controls.Add(listItems[i]);
                    }
                }
            }

        }

        public void generateCarByType() 
        {
            string carType = combo_type.SelectedValue.ToString();
            DataTable dt = dataIO.getCarByType(carType);
            generateCarsWithStatus(dt);
        }

        public void generateCarByName()
        {
            string Brand = txt_brand.Text;
            DataTable dt = dataIO.getCarByBrand(Brand);
            generateCarsWithStatus(dt);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            generateAllCars();
            DataTable dt = dataIO.getCarTypes();
            combo_type.DataSource = dt;
            combo_type.DisplayMember = "Type";
            combo_type.ValueMember = "TypeID";
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_addCar_Click(object sender, EventArgs e)
        {
            flow_main.Controls.Clear();
            AddCar add = new AddCar();
            flow_main.Controls.Add(add);
        }

        private void lbl_cars_Click(object sender, EventArgs e)
        {
            generateAllCars();
        }

        private void lbl_available_Click(object sender, EventArgs e)
        {
            generateAvailableCars();
        }

        private void lbl_rentals_Click(object sender, EventArgs e)
        {
            CurrRentals rentals = new CurrRentals();
            rentals.generateCurrRentals();
            flow_main.Controls.Clear();
            flow_main.Controls.Add(rentals);
        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {
            ViewCustomers cus = new ViewCustomers(this);
            cus.generateCustomer();
            flow_main.Controls.Clear();
            flow_main.Controls.Add(cus);
        }

        private void pic_TypeSearch_Click(object sender, EventArgs e)
        {
            generateCarByType();
        }

        private void pic_BrandSearch_Click(object sender, EventArgs e)
        {
            generateCarByName();
        }

        public void addCustomerForm()
        {
            AddCustomer addCus = new AddCustomer();
            flow_main.Controls.Clear();
            flow_main.Controls.Add(addCus);
        }

        private void lbl_rentalHistroy_Click(object sender, EventArgs e)
        {
            RentalHistory his = new RentalHistory();
            flow_main.Controls.Clear();
            his.getRentalHistory();
            flow_main.Controls.Add(his);
        }

        public void generateRentPage(RentACar rentCar)
        {
            flow_main.Controls.Clear();
            flow_main.Controls.Add(rentCar);
        }

        #region Hover Effects
        private void lbl_cars_MouseEnter(object sender, EventArgs e)
        {
            lbl_cars.ForeColor = Color.Gray;
        }

        private void lbl_cars_MouseLeave(object sender, EventArgs e)
        {
            lbl_cars.ForeColor = Color.White;
        }

        private void lbl_available_MouseEnter(object sender, EventArgs e)
        {
            lbl_available.ForeColor = Color.Gray;
        }

        private void lbl_available_MouseLeave(object sender, EventArgs e)
        {
            lbl_available.ForeColor = Color.White;
        }

        private void lbl_addCar_MouseEnter(object sender, EventArgs e)
        {
            lbl_addCar.ForeColor = Color.Gray;
        }

        private void lbl_addCar_MouseLeave(object sender, EventArgs e)
        {
            lbl_addCar.ForeColor = Color.White;
        }

        private void lbl_rentals_MouseEnter(object sender, EventArgs e)
        {
            lbl_rentals.ForeColor = Color.Gray;
        }

        private void lbl_rentals_MouseLeave(object sender, EventArgs e)
        {
            lbl_rentals.ForeColor = Color.White;
        }

        private void lbl_customer_MouseEnter(object sender, EventArgs e)
        {
            lbl_customer.ForeColor = Color.Gray;
        }

        private void lbl_customer_MouseLeave(object sender, EventArgs e)
        {
            lbl_customer.ForeColor = Color.White;
        
        }

        private void lbl_rentalHistroy_MouseEnter(object sender, EventArgs e)
        {
            lbl_rentalHistroy.ForeColor = Color.Gray;
        }

        private void lbl_rentalHistroy_MouseLeave(object sender, EventArgs e)
        {
            lbl_rentalHistroy.ForeColor = Color.White;
        }

        private void lbl_exit_MouseEnter(object sender, EventArgs e)
        {
            lbl_exit.ForeColor = Color.Gray;
        }

        private void lbl_exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_exit.ForeColor = Color.White;
        }
        #endregion


    }
}
