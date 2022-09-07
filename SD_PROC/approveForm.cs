using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_PROC
{
    public partial class approveForm : Form
    {
        public string helpValue;
        public string approvekValue
        {
            get { return textBox1.Text; }
        }

        public approveForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            if (textBox1.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                label3.Text = "Поле замечания пустое";
                label3.Visible = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void approveForm_Load(object sender, EventArgs e)
        {

            for(int i = 2; i < helpValue.Length; i++)
            {
                if ((helpValue[i] == ' ') && (helpValue[i - 1] == ' ') && (helpValue[i - 2] == ' '))
                {
                    helpValue = helpValue.Remove(i, helpValue.Length - i);
                }
            }
            textBox1.Text = helpValue;
        }
    }
}
