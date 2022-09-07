using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BLCallHelper
{
    public partial class Form1 : Form
    {
        int userId = 0;
        DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void tsButtonCalculate_Click(object sender, EventArgs e)
        {
            CalculateForm f2 = new CalculateForm();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            userId++;
            LoadNewData();
            backButton.Enabled = true;
            if (userId >= dataSet.Tables[0].Rows.Count - 1)
            {
                nextButton.Enabled = false;
            }
        }

        private void LoadNewData()
        {
            addresLabel.Text = dataSet.Tables[0].Rows[userId][0].ToString() + " " + dataSet.Tables[0].Rows[userId][1].ToString() + " к." + dataSet.Tables[0].Rows[userId][2].ToString();
            fullNameLabel.Text = dataSet.Tables[0].Rows[userId][4].ToString();
            priceLabel.Text = dataSet.Tables[0].Rows[userId][5].ToString() + " р.";
            numberTextBox.Text = dataSet.Tables[0].Rows[userId][6].ToString();
            idTextBox.Text = (userId + 2).ToString();
        }

        private void loadTSButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK) return;

            OleDbConnection myConnection;
            OleDbDataAdapter myCommand;
            myConnection = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{openFileDialog1.FileName}'; Extended Properties = Excel 8.0");

            myCommand = new OleDbDataAdapter("select * from [Лист1$]", myConnection);
            myCommand.TableMappings.Add("Table", "TestTable");

            dataSet = new DataSet();
            myCommand.Fill(dataSet);
            myConnection.Close();

            userId = 0;
            LoadNewData();

            nextButton.Enabled = true;
            backButton.Enabled = false;
            idButton.Enabled = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            userId--;
            LoadNewData();
            nextButton.Enabled = true;
            if (userId <= 0)
            {
                backButton.Enabled = false;
            }
        }

        private void idButton_Click(object sender, EventArgs e)
        {
            userId = int.Parse(idTextBox.Text) - 2;
            LoadNewData();
        }
    }
}
