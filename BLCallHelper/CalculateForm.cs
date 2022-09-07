using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLCallHelper
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {

        }

        private void rateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void routerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void tvNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void smNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void shareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            int sIndex = listBox1.SelectedIndex;
            decimal price = 0;
            switch (sIndex)
            {
                case 0: // Для дома 100
                    price = 450;
                    break;
                case 1: // Для дома 300
                    price = 600;
                    break;
                case 2: // Для дома 500
                    price = 700;
                    break;
                case 3: // Для дома с ТВ 100
                    price = 600;
                    break;
                case 4: // Для дома с ТВ 300
                    price = 690;
                    break;
                case 5: // Для дома с ТВ 500
                    price = 890;
                    break;
                case 6: // Для тебя и дома 1
                    price = 750;
                    break;
                case 7: // Для тебя и дома 2
                    price = 1000;
                    break;
                case 8: // На максимум! +
                    price = 1800;
                    break;
                default:
                    price = 0;
                    break;
            }

            if (routerCheckBox.Checked) // Роутер
            {
                price += 100;
                if (sIndex < 3)
                    price += 50;
            }

            decimal tvCount = tvNumericUpDown.Value - smNumericUpDown.Value;
            if ((sIndex > 2) && (tvCount > 0)) // Приставки
                price += (tvCount) * 200 - 100;

            if ((shareCheckBox.Checked) && ((sIndex == 6) || (sIndex == 7))) // "Дели все"
                price += 200;

            labelPrice.Text = price.ToString();
        }
    }
}
