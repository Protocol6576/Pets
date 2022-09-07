using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SD_PROC.assets;

namespace SD_PROC
{
    public partial class AgreementForm : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable table = new DataTable();
        DataBase dataBase = new DataBase();
        public string idSdProc;
        public string idDep;

        public AgreementForm()
        {
            InitializeComponent();
        }

        private void Agreement_Load(object sender, EventArgs e)
        {

            dataBase.openConnection();

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 300;
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ID_DEP"].Width = 30;
            dataGridView1.Columns["USER_PHOTO"].Width = 227;
            dataGridView1.Columns["ALL_DATA"].Width = 227;

            dataGridView1.Columns["ID_DEP"].HeaderText = "";
            dataGridView1.Columns["USER_PHOTO"].HeaderText = "Кто поставил";
            dataGridView1.Columns["ALL_DATA"].HeaderText = "Замечение";

            if (idDep == "Все")
            {
                approveToolStripButton.Enabled = false;
                remarkToolStripButton.Enabled = false;
            }

            dataGridView1.DataSource = table;

        }

        private void approveToolStripButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string CmdText = $"SELECT ID_USER, SD_APPR_REQ_ID FROM SD_APPR_REQ WHERE (ID_DEP = '{idDep}') and (ID_SD_PROC = '{idSdProc}')";
            SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);


            approveForm remark = new approveForm();
            remark.helpValue = table.Rows[0].ItemArray[0].ToString();
            if (remark.ShowDialog() == DialogResult.OK)
            {

                string ID_USER = remark.approvekValue;
                string ID_SD_APPR_REQ = table.Rows[0].ItemArray[1].ToString();
                int PR_A = 0;
                string PRIM = "";
                string USER_DATE = DateTime.Now.ToString();

                CmdText = "INSERT INTO SD_APPROVED " +
                    "(ID_USER, ID_SD_APPR_REQ, ID_SD_PROC, PR_A, PRIM, USER_DATE) VALUES " +
                    $"('{ID_USER}', '{ID_SD_APPR_REQ}', '{idSdProc}', {PR_A}, '{PRIM}',  '{USER_DATE}')";
                command = new SqlCommand(CmdText, dataBase.getConnection());
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
            }
        }

        private void remarkToolStripButton2_Click(object sender, EventArgs e)
        {
            RemarkForm remark = new RemarkForm();
            if(remark.ShowDialog() == DialogResult.OK)
            {
                DataTable table = new DataTable();
                string CmdText = $"SELECT TOP (1) ID_USER, ID_SERVICE FROM SD_APPR_REQ WHERE ID_DEP = '{idDep}'";
                SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                string ID_USER = table.Rows[0].ItemArray[0].ToString();
                string R_TEXT = remark.remarkValue;
                int PR_A = 0;
                string PRIM = "";
                string USER_DATE = DateTime.Now.ToString();

                CmdText = "INSERT INTO SD_REMARK " +
                    "(ID_SD_PROC, ID_USER, R_TEXT, PR_A, PRIM, USER_DATE) VALUES " +
                    $"('{idSdProc}', '{ID_USER}', '{R_TEXT}', {PR_A}, '{PRIM}', '{USER_DATE}')";
                command = new SqlCommand(CmdText, dataBase.getConnection());
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
            }
        }
    }
}
