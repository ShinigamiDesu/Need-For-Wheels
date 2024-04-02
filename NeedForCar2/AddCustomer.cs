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
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        DataIO dataIO = new DataIO();

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_FN.Text == "" || txt_FN.Text == "" || txt_License.Text == "" || txt_phone.Text == "") 
            {
                lbl_confirm.Visible = false;
                lbl_error.Visible = true;   
            }
            else 
            { 
                dataIO.addCustomer(txt_FN.Text, txt_LN.Text, txt_License.Text, txt_phone.Text);
                lbl_confirm.Visible = true;
                txt_FN.Text = "";
                txt_FN.Text = "";
                txt_License.Text = "";
                txt_phone.Text = "";
            }
        }
    }
}
