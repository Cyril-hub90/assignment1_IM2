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
     public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
         
            if (txtFirstname.Text == "" || txtLastname.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string mobile = txtMobile.Text.Trim();

           
            if (mobile.Length != 11)
            {
                MessageBox.Show("Mobile number must be exactly 11 digits long.");
                return;
            }

            
            if (!mobile.All(char.IsDigit))
            {
                MessageBox.Show("Mobile number must contain only digits.");
                return;
            }

            
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string sex = rbMale.Checked ? "Male" : "Female";
            string status = cmbStatus.SelectedItem?.ToString() ?? "";
            DateTime birthday = dtpBirthday.Value;
            string location = txtLocation.Text;
            Image userImage = pictureBoxPhoto.Image;

            
            Form2 form2 = new Form2(mobile, firstname, lastname, sex, status, birthday, location, userImage);
            form2.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
