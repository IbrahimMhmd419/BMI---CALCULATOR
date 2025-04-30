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

namespace BMI_CALCULATOR
{
    public partial class form1 : Form
    {
        List<User> Users = new List<User>();
        public form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                User _user = new User();

                _user.Name = NameTextBox.Text;
                _user.Age = int.Parse(AgeTextBox.Text);
                _user.Weight = double.Parse(WeightTextBox.Text);
                _user.HeightCm = double.Parse(HeightTextBox.Text);

                _user.CalculateBmI();
                Users.Add(_user);
                MessageBox.Show($"Hello {_user.Name}\n Your BMI Is:{_user.BMI} \n{_user.Category}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            WeightTextBox.Clear();
            HeightTextBox.Clear();
        }
    }
}
