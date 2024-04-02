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
    public partial class Cars : UserControl
    {
        private string _CarID;
        private string _CarModel;
        private string _CarBrand;
        private string _CarName;
        private string _Engine;
        private string _Power;
        private string _Speed;
        private string _Plate;
        private Image _carPic;
        private Image _carStatus;
        private MainPage mainPage;

        DataIO dataIO = new DataIO();

        public Cars(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        public string CarID {  get { return _CarID; } set {  _CarID = value; lbl_CarID.Text = value; } }
        public string CarName { get { return _CarName; } set { _CarName = value; lbl_Name.Text = value; } }
        public string CarModel { get { return _CarModel; } set { _CarModel = value; lbl_model.Text = value; } }
        public string CarBrand { get { return _CarBrand; } set { _CarBrand = value; lbl_brand.Text = value; } }
        public string Power { get { return _Power; } set { _Power = value; lbl_power.Text = value; } }
        public string Engine { get { return _Engine;} set { _Engine = value; lbl_engine.Text = value; } }
        public string Speed { get { return _Speed; } set { _Speed = value; lbl_speed.Text = value; } }
        public string Plate { get { return _Plate; } set { _Plate = value; } }
        public Image Pic { get { return _carPic; } set { _carPic = value; pic_car.Image = value; } }
        public Image carStatus { get { return _carStatus; } set { _carStatus = value; pic_status.Image = value; } }

        public void SetRentButtonVisibility(bool isVisible)
        {
            btn_rent.Visible = isVisible;
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            RentACar rent = new RentACar(mainPage);
            rent.Pic = _carPic;
            rent.carID = _CarID;
            rent.carName = _CarName;
            rent.carPlate = _Plate;
            mainPage.generateRentPage(rent);

        }
    }
}
