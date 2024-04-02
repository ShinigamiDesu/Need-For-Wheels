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
    public partial class RentalHistory : UserControl
    {
        DataIO dataIO = new DataIO();
        public RentalHistory()
        {
            InitializeComponent();
        }

        private void RentalHistory_Load(object sender, EventArgs e)
        {

        }

        public void getRentalHistory() 
        { 
            DataTable dt = dataIO.getRentalHistory();
            try
            {
                data_grid.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string rented = dt.Rows[i]["date_rented"].ToString();
                    string returned = dt.Rows[i]["date_returned"].ToString();
                    int n = data_grid.Rows.Add();
                    data_grid.Rows[n].Cells[0].Value = dt.Rows[i]["HistoryID"].ToString();
                    data_grid.Rows[n].Cells[1].Value = dt.Rows[i]["cus_FN"].ToString();
                    data_grid.Rows[n].Cells[2].Value = dt.Rows[i]["cus_LN"].ToString();
                    data_grid.Rows[n].Cells[3].Value = dt.Rows[i]["car_Name"].ToString();
                    data_grid.Rows[n].Cells[4].Value = dt.Rows[i]["car_LicensePlate"].ToString();
                    if (returned == "")
                    {
                        data_grid.Rows[n].Cells[5].Value = dt.Rows[i]["date_rented"].ToString();
                        data_grid.Rows[n].Cells[6].Value = "Not Returned";
                    }
                    else
                    {
                        data_grid.Rows[n].Cells[5].Value = dt.Rows[i]["date_rented"].ToString();
                        data_grid.Rows[n].Cells[6].Value = dt.Rows[i]["date_returned"].ToString();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
