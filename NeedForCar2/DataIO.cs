using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NeedForCar2
{
    internal class DataIO
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\NeedForCar2\\NeedForCar2\\CarRental.mdf\";Integrated Security=True");



        public DataTable getCarTypes() 
        {
            string selecting = "SELECT * FROM tbl_CarType";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting,con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void AddCar(string Name, string Brand, string Model, string Engine, string Power, string Speed, string Type, byte[] Pic, string License)
        {
            int type = int.Parse(Type);
            string insert = "INSERT INTO tbl_Car(car_Name, car_Model, car_Brand, car_Engine, car_Power, car_Speed, car_Type, car_ImgValue, car_LicensePlate) VALUES(@name, @model, @brand, @engine, @power, @speed, @type, @pic, @license)";
            SqlCommand cmd = new SqlCommand(insert,con);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@model", Model);
            cmd.Parameters.AddWithValue("@brand", Brand);
            cmd.Parameters.AddWithValue("@engine", Engine);
            cmd.Parameters.AddWithValue("@power", Power);
            cmd.Parameters.AddWithValue("@speed", Speed);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@pic", Pic);
            cmd.Parameters.AddWithValue("@license", License);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Name + " Has Been Added.");
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getAllCars() 
        {
            string Selecting = "SELECT * FROM tbl_Car";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting,con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getAllAvailableCars()
        {
            string Selecting = "SELECT * FROM tbl_Car WHERE car_Rent_Status = 0";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getCurrentRentals() 
        {
            string Selecting = "SELECT * FROM tbl_RentalHistory JOIN tbl_Car ON tbl_RentalHistory.car_ID = tbl_Car.CarID JOIN tbl_Customer ON tbl_RentalHistory.cus_ID = tbl_Customer.CustomerID WHERE tbl_Car.car_Rent_Status = 1 and tbl_RentalHistory.date_returned IS NULL";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting,con);
            DataTable dt = new DataTable(); 
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getCustomers()
        {
            string Select = "Select * FROM tbl_Customer";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getCarByType(string type) 
        {
            string Select = "Select * FROM tbl_Car WHERE car_Type = '"+type+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getCarByBrand(string name)
        {
            string Select = "Select * FROM tbl_Car WHERE car_Brand LIKE '%" + name + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void updateRentStatus(string carID, string cusID, string time, string HistoryID) 
        {
            string command = "UPDATE tbl_Car SET car_Rent_Status = 0 WHERE CarID = '"+carID+"'; UPDATE tbl_RentalHistory SET date_returned = '"+time+"' WHERE  HistoryID = '"+HistoryID+"'";
            SqlCommand cmd = new SqlCommand(command, con);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Car Returned at: " + time);
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getRentalHistory() 
        {
            string Selecting = "SELECT * FROM tbl_RentalHistory JOIN tbl_Car ON tbl_RentalHistory.car_ID = tbl_Car.CarID JOIN tbl_Customer ON tbl_RentalHistory.cus_ID = tbl_Customer.CustomerID";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void insertRentData(int cusID,int carID) 
        {
            string INSERT = "INSERT INTO tbl_RentalHistory(cus_ID, car_ID) VALUES(@cusID1, @carID1); UPDATE tbl_Car SET car_Rent_Status = 1 WHERE CarID = '"+carID+"'";
            SqlCommand cmd = new SqlCommand(INSERT, con);
            cmd.Parameters.AddWithValue("@cusID1", cusID);
            cmd.Parameters.AddWithValue("@carID1", carID);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rent Successful!");
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message );
            }
        }

        public void addCustomer(string fn, string ln, string license, string phone) 
        {
            string Insert = "INSERT INTO tbl_Customer(cus_FN, cus_LN, cus_LicenseID, cus_PhoneNo) VALUES(@fn, @ln, @license, @phone)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@license", license);
            cmd.Parameters.AddWithValue("@phone", phone);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public DataTable searchCusByFN(string name) 
        {
            string Select = "SELECT * FROM tbl_Customer WHERE tbl_Customer.cus_FN LIKE '%"+name+"%'";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable searchCusByLN(string name)
        {
            string Select = "SELECT * FROM tbl_Customer WHERE tbl_Customer.cus_LN LIKE '%" + name + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable searchCusByPhone(string phone)
        {
            string Select = "SELECT * FROM tbl_Customer WHERE tbl_Customer.cus_PhoneNo LIKE '%" + phone + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable searchRentalByLN(string name)
        {
            string Select = "SELECT * FROM tbl_RentalHistory JOIN tbl_Car ON tbl_RentalHistory.car_ID = tbl_Car.CarID JOIN tbl_Customer ON tbl_RentalHistory.cus_ID = tbl_Customer.CustomerID WHERE tbl_Customer.cus_LN LIKE '%"+name+ "%' AND tbl_Car.car_Rent_Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable searchRentalByPhone(string phone)
        {
            string Select = "SELECT * FROM tbl_RentalHistory JOIN tbl_Car ON tbl_RentalHistory.car_ID = tbl_Car.CarID JOIN tbl_Customer ON tbl_RentalHistory.cus_ID = tbl_Customer.CustomerID WHERE tbl_Customer.cus_PhoneNo LIKE '%"+phone+"%' AND tbl_Car.car_Rent_Status = 1"; ;
            SqlDataAdapter adapt = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

    }




}
