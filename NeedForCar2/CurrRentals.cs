using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedForCar2
{
    public partial class CurrRentals : UserControl
    {
         string timestamp;
        public CurrRentals()
        {
            InitializeComponent();
            DateTime currentTimestamp = DateTime.Now;
            string formattedTimestamp = currentTimestamp.ToString("MM/dd/yyyy hh:mm:ss tt");
            timestamp = formattedTimestamp;
        }
        DataIO dataIO = new DataIO();

        public void generateData(DataTable dt) 
        {
            data_grid.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int n = data_grid.Rows.Add();
                data_grid.Rows[n].Cells[0].Value = dt.Rows[i]["HistoryID"].ToString();
                data_grid.Rows[n].Cells[1].Value = dt.Rows[i]["cus_ID"].ToString();
                data_grid.Rows[n].Cells[2].Value = dt.Rows[i]["car_ID"].ToString();
                data_grid.Rows[n].Cells[3].Value = dt.Rows[i]["cus_FN"].ToString();
                data_grid.Rows[n].Cells[4].Value = dt.Rows[i]["cus_LN"].ToString();
                data_grid.Rows[n].Cells[5].Value = dt.Rows[i]["cus_PhoneNo"].ToString();
                data_grid.Rows[n].Cells[6].Value = dt.Rows[i]["car_Name"].ToString();
                data_grid.Rows[n].Cells[7].Value = dt.Rows[i]["car_Brand"].ToString();
            }
        }

        public void generateCurrRentals() 
        {
            int dataCount = 0;
            DataTable dt = dataIO.getCurrentRentals();
            DataTable dt1 = dataIO.getAllCars();
            foreach(DataRow row in dt1.Rows) 
            {
                int rentStatus = Convert.ToInt32(row["car_Rent_Status"]);
                if (rentStatus == 1) 
                {
                    dataCount = 1; 
                    break;
                }
            }
            if (dataCount == 1)
            {
                lbl_error.Visible = false;
                data_grid.Visible = true;
                pic_phone.Visible = true;
                pic_ln.Visible = true;
                txt_ln.Visible = true;
                txt_phone.Visible = true;
                panel3.Visible = true;
                panel2.Visible = true;
                generateData(dt);
            }
            else
            {
                pic_phone.Visible = false;
                txt_ln.Visible = false;
                txt_phone.Visible = false;
                pic_ln.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;
                lbl_error.Visible = true;
                data_grid.Visible = false;
            }
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string HistoryID = data_grid.SelectedCells[0].Value.ToString();
            string car = data_grid.SelectedCells[6].Value.ToString();
            string carID = data_grid.SelectedCells[2].Value.ToString();
            string cusID = data_grid.SelectedCells[1].Value.ToString();

            if (data_grid.Columns[e.ColumnIndex].Name == "update") 
            {
                DialogResult dialogResult = MessageBox.Show("This is to confirm that the car " + '"' + car + '"' + " has been returned?", "Car Return", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataIO.updateRentStatus(carID, cusID, timestamp, HistoryID);
                    generateCurrRentals();
                }
            }
        }

        private void pic_phone_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.searchRentalByLN(txt_ln.Text);
            generateData(dt);
        }

        private void pic_ln_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.searchRentalByPhone(txt_phone.Text);
            generateData(dt);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            generateCurrRentals();
            txt_ln.Text = "";
            txt_phone.Text = "";
        }
    }
}
