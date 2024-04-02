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
    public partial class RentACar : UserControl
    {
        public RentACar(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        private string _carName {  get; set; }
        private string _carID { get; set; }
        private string _carPlate {  get; set; }
        private Image _carPic { get; set; }
        private string _CusID { get; set; }
        private MainPage mainPage;

        DataIO dataIO = new DataIO();

        public string carName { get { return _carName; } set { _carName = value; lbl_carName.Text = value; } }
        public string carID { get { return _carID; } set { _carID = value; } }
        public string carPlate { get { return _carPlate; } set { _carPlate = value; txt_Plate.Text = value; } }
        public Image Pic { get { return _carPic; } set { _carPic = value; pic_car.Image = value; } }

        private void RentACar_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getCustomers();
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_FN.Text = "";
            txt_LN.Text = "";
            txt_License.Text = "";
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            if(txt_FN.Text == "") 
            {
                lbl_error.Visible = true;
            }
            else 
            {
                int carID = int.Parse(_carID);
                int cusID = int.Parse(_CusID);
                dataIO.insertRentData(cusID, carID);
                mainPage.generateAllCars();
            }


        }

        private void data_grid_Click(object sender, EventArgs e)
        {
            _CusID = data_grid.SelectedRows[0].Cells[0].Value.ToString();
            txt_FN.Text = data_grid.SelectedRows[0].Cells[1].Value.ToString();
            txt_LN.Text = data_grid.SelectedRows[0].Cells[2].Value.ToString();
            txt_License.Text = data_grid.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
