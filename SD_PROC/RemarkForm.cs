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
    public partial class RemarkForm : Form
    {
        public string remarkValue
        {
            get { return richTextBox1.Text; }
        }

        public RemarkForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            if (richTextBox1.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                label3.Text = "Поле замечания пустое";
                label3.Visible = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
