using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstname, string lastname, string sex, string status, DateTime birthday, string location, Image userImage)
        {
            InitializeComponent();

            
            txtMobileDisplay.Text = mobile;
            txtFirstnameDisplay.Text = firstname;
            txtLastnameDisplay.Text = lastname;

            if (sex == "Male")
                rbMaleDisplay.Checked = true;
            else
                rbFemaleDisplay.Checked = true;

            cmbStatusDisplay.SelectedItem = status;
            dtpBirthdayDisplay.Value = birthday;
            txtLocationDisplay.Text = location;

            if (userImage != null)
                pictureBoxDisplay.Image = userImage;
        }

        private void S(object sender, EventArgs e)
        {

        }
    }
}
