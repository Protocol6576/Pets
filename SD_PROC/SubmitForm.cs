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
    public partial class SubmitForm : Form
    {
        public List<string> departaments = new List<string> { };
        int[] formSize = { 275, 550 };

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataBase dataBase = new DataBase();

        public SubmitForm()
        {
            InitializeComponent();
            this.Width = formSize[0];
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            label3.Visible = false;
            if ((sdProcIdTextBox.Text != "") && (idSetTextBox.Text != ""))
            {

                if (depCheckedListBox.CheckedIndices.Count > 0)
                {
                    string CmdText = "select " +
                    "CASE WHEN EXISTS( " +
                    "select SD_PROC.SD_PROC_ID " +
                    "from SD_PROC " +
                    $"where (SD_PROC_ID = '{sdProcIdTextBox.Text}') " +
                    ") THEN 1 ELSE 0 END";
                    SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows[0].ItemArray[0].ToString() == "0")
                    {

                        table = new DataTable();
                        string SD_PROC_ID = sdProcIdTextBox.Text;
                        string DATE_I = DateTime.Now.ToString();
                        string ID_USER = "test_1";
                        string ID_SET = idSetTextBox.Text;
                        int STARUS = 1;
                        int PR_A = 0;
                        string PRIM = richTextBox1.Text;
                        string USER_DATE = DateTime.Now.ToString();

                        dataBase.openConnection();
                        CmdText = "INSERT INTO SD_PROC " +
                            "(SD_PROC_ID, DATE_I, ID_USER, ID_SET, STATUS, PR_A, PRIM, USER_DATE) VALUES " +
                            $"('{SD_PROC_ID}', '{DATE_I}', '{ID_USER}', '{ID_SET}', {STARUS}, {PR_A}, '{PRIM}', '{USER_DATE}')";

                        command = new SqlCommand(CmdText, dataBase.getConnection());
                        adapter.InsertCommand = command;
                        adapter.InsertCommand.ExecuteNonQuery();

                        for (int i = 0; i < depCheckedListBox.CheckedIndices.Count; i++)
                        {
                            string ID_DEP = depCheckedListBox.CheckedItems[i].ToString();
                            CmdText = $"SELECT TOP (1) ID_USER, ID_SERVICE FROM SD_APPR_REQ WHERE ID_DEP = '{ID_DEP}'";
                            command = new SqlCommand(CmdText, dataBase.getConnection());
                            adapter.SelectCommand = command;
                            table = new DataTable();
                            adapter.Fill(table);

                            CmdText = "INSERT INTO SD_APPR_REQ " +
                            "(ID_SD_PROC, ID_USER, ID_DEP, ID_SERVICE, PR_A, PRIM, USER_DATE) VALUES " +
                            $"('{SD_PROC_ID}', '{table.Rows[0].ItemArray[0].ToString()}', '{ID_DEP}', '{table.Rows[0].ItemArray[1].ToString()}', '{PR_A}', '{PRIM}', '{USER_DATE}')";
                            command = new SqlCommand(CmdText, dataBase.getConnection());
                            adapter.InsertCommand = command;
                            adapter.InsertCommand.ExecuteNonQuery();
                        }

                        this.Close();
                    }
                    else
                    {
                        label3.Text = "Данное обозначение уже занято";
                        label3.Visible = true;
                    }
                }
                else
                {
                    label3.Text = "Ни один отдел не выбран";
                    label3.Visible = true;
                }
            }
            else
            {
                label3.Text = "Одно или несколько полей не заполненны";
                label3.Visible = true;
            }
        }

        private void SumbitForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < departaments.Count; i++) 
                depCheckedListBox.Items.Add(departaments[i], true);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                idSetTextBox.Text = ofd.FileName;
            }
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            if(this.Width == formSize[0])
            {
                this.Width = formSize[1];
                noteButton.Text = "Скрыть примечание";
            }
            else
            {
                this.Width = formSize[0];
                if(richTextBox1.Text == "")
                {
                    noteButton.Text = "Добавить примечание";
                }
                else
                {
                    noteButton.Text = "Изменить примечание";
                }
            }
        }
    }
}
