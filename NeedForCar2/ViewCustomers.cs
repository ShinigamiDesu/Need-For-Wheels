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
    public partial class ViewCustomers : UserControl
    {
        MainPage mainPage;
        public ViewCustomers(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        DataIO dataIO = new DataIO();

        public void generateCustomer() 
        {
            DataTable dt = dataIO.getCustomers();
            generateData(dt);
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            mainPage.addCustomerForm();
        }

        public void generateData(DataTable dt) 
        {
            data_grid.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int n = data_grid.Rows.Add();
                data_grid.Rows[n].Cells[0].Value = dt.Rows[i]["CustomerID"].ToString();
                data_grid.Rows[n].Cells[1].Value = dt.Rows[i]["cus_FN"].ToString();
                data_grid.Rows[n].Cells[2].Value = dt.Rows[i]["cus_LN"].ToString();
                data_grid.Rows[n].Cells[3].Value = dt.Rows[i]["cus_PhoneNo"].ToString();
                data_grid.Rows[n].Cells[4].Value = dt.Rows[i]["cus_LicenseID"].ToString();
            }
        }

        private void pic_FN_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.searchCusByFN(txt_FN.Text);
            generateData(dt);
        }

        private void pic_ln_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.searchCusByLN(txt_ln.Text);
            generateData(dt);
        }

        private void pic_phone_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.searchCusByPhone(txt_phone.Text);
            generateData(dt);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            generateCustomer();
            txt_ln.Text = "";
            txt_FN.Text = "";
            txt_phone.Text = "";
        }
    }
}
