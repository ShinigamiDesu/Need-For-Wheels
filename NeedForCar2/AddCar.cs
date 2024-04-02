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
    public partial class AddCar : UserControl
    {
        public AddCar()
        {
            InitializeComponent();
        }
        string path;
        byte[] pic;
        DataIO dataIO = new DataIO();

        private void AddCar_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getCarTypes();
            combo_type.DataSource = dt;
            combo_type.DisplayMember = "Type";
            combo_type.ValueMember = "TypeID";
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_car.ImageLocation = ImagePath;
                path = ImagePath;
            }
            byte[] imagebyte = null;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagebyte = br.ReadBytes((int)fs.Length);
            pic = imagebyte;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_brand.Text == "" || txt_engine.Text == "" || txt_Name.Text == "" || txt_power.Text == "" || txt_speed.Text == "" || txt_model.Text == "" || txt_license.Text == ""|| pic_car.Image == null)
            {
                lbl_error.Visible = true;
            }
            else
            {
                dataIO.AddCar(txt_Name.Text, txt_brand.Text, txt_model.Text, txt_engine.Text, txt_power.Text, txt_speed.Text, combo_type.SelectedValue.ToString(), pic, txt_license.Text);
                lbl_error.Visible = false;
                txt_Name.Text = "";
                txt_brand.Text = "";
                txt_model.Text = "";
                txt_engine.Text = "";
                txt_power.Text = "";
                txt_speed.Text = "";
                pic_car.Image = null;
            }

        }

    }
}
