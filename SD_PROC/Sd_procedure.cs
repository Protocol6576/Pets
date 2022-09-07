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
using Excel = Microsoft.Office.Interop.Excel;

namespace SD_PROC
{
    public partial class Sd_procedure : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataBase dataBase = new DataBase();

        List<string> departaments = new List<string> {
            "21", "22", "23", "24", "31", "41", "42", "51", "11",
            "Хозяева помещения", "Мат. контроль", "Тех. контроль", "Нормоконтроль", "ОГК", "Завод" };

        public Sd_procedure()
        {
            InitializeComponent();
        }

        private void Sd_procedure_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            FillDataGrid("");
            ColorDataGrid();

            dataGridView1.Columns["SD_PROC_ID"].HeaderText = "Обозначение";
            dataGridView1.Columns["DATE_I"].HeaderText = "Поставлен";
            dataGridView1.Columns["USER_DATE"].HeaderText = "Изменен";
            dataGridView1.Columns["ID_SET"].HeaderText = "Наименование";
            dataGridView1.Columns["ID_USER"].HeaderText = "Кем поставлен";
            for (int i = 5; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = "";
                if(dataGridView1.Columns[i].Name.Length < 5)
                    dataGridView1.Columns[i].Width = 50;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns["ID_SET"].Width = 200;
        }

        private void Sd_procedure_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataBase.closeConnection();
        }

        private void ColorDataGrid()
        {
            DataTable table2 = new DataTable();
            int columnsCount = dataGridView1.ColumnCount;
            int rowCount = dataGridView1.RowCount;

            string idDep = string.Empty;
            string idSdProc = string.Empty;
            string CmdText = string.Empty;

            SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
            adapter.SelectCommand = command;

            int colour = 0;
            for (int i = 0; i < rowCount; i++)
            {
                idSdProc = dataGridView1[0, i].Value.ToString();
                for (int j = 5; j < columnsCount; j++)
                {
                    idDep = dataGridView1[j, i].Value.ToString();
                    CmdText = "select " +

                    "CASE WHEN EXISTS( " +
                    "select SD_APPR_REQ.ID_USER " +
                    "from SD_APPR_REQ " +
                    $"where (ID_DEP = '{idDep}') and (SD_APPR_REQ.ID_SD_PROC = '{idSdProc}') and (SD_APPR_REQ.PR_A = 0) " +
                    ") THEN 1 ELSE 0 END, " +

                    "CASE WHEN EXISTS( " +
                    "select SD_APPR_REQ.ID_USER " +
                    "from SD_APPR_REQ, SD_REMARK " +
                    $"where (SD_APPR_REQ.ID_SD_PROC = SD_REMARK.ID_SD_PROC) and(SD_APPR_REQ.ID_USER = SD_REMARK.ID_USER) and (ID_DEP = '{idDep}') and (SD_APPR_REQ.ID_SD_PROC = '{idSdProc}') and (SD_REMARK.PR_A = 0) " +
                    ") THEN 1 ELSE 0 END, " +

                    "CASE WHEN EXISTS( " +
                    "select SD_APPR_REQ.ID_USER " +
                    "from SD_APPR_REQ, SD_APPROVED " +
                    $"where (ID_SD_APPR_REQ = SD_APPR_REQ_ID) and (ID_DEP = '{idDep}') and (SD_APPR_REQ.ID_SD_PROC = '{idSdProc}') and (SD_APPROVED.PR_A = 0) " +
                    ") THEN 1 ELSE 0 END, " +

                    "CASE WHEN EXISTS( " +
                    "select SD_APPR_REQ.ID_USER " +
                    "from SD_APPR_REQ, SD_APPROVED " +
                    $"where (ID_SD_APPR_REQ = SD_APPR_REQ_ID) and (ID_DEP = '{idDep}') and (SD_APPR_REQ.ID_SD_PROC = '{idSdProc}') and (SD_APPROVED.PR_A = 0) and (SD_APPR_REQ.ID_USER = SD_APPROVED.ID_USER)" +
                    ") THEN 1 ELSE 0 END";

                    command = new SqlCommand(CmdText, dataBase.getConnection());
                    adapter.SelectCommand = command;

                    table2 = new DataTable();
                    adapter.Fill(table2);
                    for(int l = 0; l < table2.Columns.Count; l++)
                    {
                        if (table2.Rows[0].ItemArray[l].ToString() == "1")
                            colour = l + 1;
                    }
                    switch (colour)
                    {
                        case 1:
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            break;
                        case 2:
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Brown;
                            break;
                        case 3:
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                            break;
                        case 4:
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                            break;

                    }
                    colour = 0;
                    table2 = new DataTable();
                }
            }

            int allPos = dataGridView1.ColumnCount - departaments.Count - 3 + 1;
            for (int i = 0; i < rowCount; i++)
            {
                idSdProc = dataGridView1[0, i].Value.ToString();
                CmdText = $"select STATUS from SD_PROC WHERE (SD_PROC.SD_PROC_ID = '{idSdProc}')";

                command = new SqlCommand(CmdText, dataBase.getConnection());
                adapter.SelectCommand = command;

                table2 = new DataTable();
                adapter.Fill(table2);

                colour = int.Parse(table2.Rows[0].ItemArray[0].ToString());
                switch (colour)
                {
                    case 1:
                        dataGridView1.Rows[i].Cells[allPos].Style.BackColor = Color.Red;
                        break;
                    case 2:
                        dataGridView1.Rows[i].Cells[allPos].Style.BackColor = Color.Brown;
                        break;
                    case 3:
                        dataGridView1.Rows[i].Cells[allPos].Style.BackColor = Color.Blue;
                        break;
                    case 4:
                        dataGridView1.Rows[i].Cells[allPos].Style.BackColor = Color.Green;
                        break;
                    case 5:
                        dataGridView1.Rows[i].Cells[allPos].Style.BackColor = Color.Yellow;
                        break;

                }
            }
        }

        private void FillDataGrid(string fillCondition)
        {
            string CmdText =
            $"select SD_PROC_ID, DATE_I, USER_DATE, ID_SET, ID_USER, 'Все' as 'All', {ParseDep()}, 'Печать' as 'Print' " +
            "from (select t1.SD_PROC_ID, t1.DATE_I, t1.USER_DATE, t1.ID_SET, t1.ID_USER, t2.ID_DEP, t1.PR_A as PROC_PR_A, t2.PR_A as DEP_PR_A, STATUS " +
            "from SD_APPR_REQ t2 inner join SD_PROC t1 on t2.ID_SD_PROC = t1.SD_PROC_ID " +
            $"WHERE (t1.PR_A = 0) and (t2.PR_A = 0) {fillCondition} " +
            ") as sourse " +
            "PIVOT( " +
            "MAX(ID_DEP) " +
            $"FOR ID_DEP in ({ParseDep()}) " +
            ") as pvt";

            SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            
            string name;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                name = dataGridView1[3, i].Value.ToString();
                dataGridView1[3, i].Value = name.Substring(name.LastIndexOf("\\") + 1);
            }

        }

        private string ParseDep()
        {
            string deps = "";
            for (int i = 0; i < departaments.Count; i++)
                deps += $"[{departaments[i]}],";
            deps = deps.Remove(deps.Length - 1, 1);

            return deps;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable table2 = new DataTable();
            int currentCellColumn = dataGridView1.CurrentCell.ColumnIndex;
            if ((currentCellColumn > dataGridView1.ColumnCount - departaments.Count - 3) && (currentCellColumn < dataGridView1.ColumnCount - 1))
            {

                string idDep = dataGridView1.CurrentCell.Value.ToString();
                if (idDep != "")
                {

                    string idSdProc = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();

                    string CmdText =
                    "select ID_DEP, SD_REMARK.ID_USER as USER_PHOTO, concat(SD_REMARK.ID_USER, CHAR(13) + CHAR(10), SD_REMARK.R_TEXT) as ALL_DATA " +
                    "from SD_REMARK, SD_APPR_REQ, SD_APPROVED " +
                    "where(ID_SD_APPR_REQ = SD_APPR_REQ_ID) and (SD_APPR_REQ.ID_SD_PROC = SD_REMARK.ID_SD_PROC) " +
                    $"and (SD_APPROVED.ID_USER = SD_REMARK.ID_USER) ";

                    if (idDep != "Все")
                    {
                        CmdText += $"and (ID_DEP = '{idDep}') ";
                    }
                    CmdText += $"and (SD_APPR_REQ.ID_SD_PROC = '{idSdProc}')";
                    SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
                    adapter.SelectCommand = command;
                    table2 = new DataTable();
                    adapter.Fill(table2);

                    AgreementForm agreement = new AgreementForm();
                    agreement.table = table2;
                    agreement.idDep = idDep;
                    agreement.idSdProc = idSdProc;

                    agreement.FormClosed += (obj, arg) =>
                    {
                        FillDataGrid("");
                        ColorDataGrid();
                    };
                    agreement.Show();
                }
            }
        }

        private void submitProcButton_Click(object sender, EventArgs e)
        {
            SubmitForm submitForm = new SubmitForm();
            submitForm.departaments = departaments;
            submitForm.FormClosed += (obj, arg) =>
            {
                FillDataGrid("");
                ColorDataGrid();
            };
            submitForm.Show();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            ColorDataGrid();
        }

        private void allToolStripButton_Click(object sender, EventArgs e)
        {
            FillDataGrid("");
            ColorDataGrid();
        }

        private void exelImportToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                xlApp.Visible = true;

                Excel.Workbook wBook;
                Excel.Worksheet xlSheet;
                wBook = xlApp.Workbooks.Add();
                xlApp.Columns.ColumnWidth = 30;
                xlSheet = (Excel.Worksheet)wBook.Sheets[1];
                xlSheet.Name = "Процедуры согласования";


                xlApp.Cells[1, 1] = "Обозначение";
                xlApp.Cells[1, 2] = "Поставлен";
                xlApp.Cells[1, 3] = "Изменен";
                xlApp.Cells[1, 4] = "Наименование";
                xlApp.Cells[1, 5] = "Кем поставлен";
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        xlApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        if(dataGridView1.Rows[i].Cells[j].Style.BackColor != Color.White)
                            xlApp.Cells[i + 2, j + 1].Font.Color = dataGridView1.Rows[i].Cells[j].Style.BackColor;

                        xlSheet.Cells.HorizontalAlignment = 3;
                        xlApp.Visible = true;
                    }
                }
                xlSheet.Cells.HorizontalAlignment = 3;
                xlApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void yellowFilterToolStripButton_Click(object sender, EventArgs e)
        {
            FillDataGrid("and (t1.STATUS = 5)");
            ColorDataGrid();
        }

        private void redFilterToolStripButton_Click(object sender, EventArgs e)
        {
            FillDataGrid("and (t1.STATUS = 1)");
            ColorDataGrid();
        }

        private void deleteProcToolStripButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow is null)
            {
                DialogResult dialogResult = MessageBox.Show("Для удаленивы выделите строчку", "Удаление записи", MessageBoxButtons.OK);
            }
            else
            {
                string idSdProc = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                string CmdText = $"UPDATE SD_PROC SET PR_A = 1, USER_DATE = '{DateTime.Now.ToString()}' WHERE (SD_PROC_ID = {idSdProc}) ";
                SqlCommand command = new SqlCommand(CmdText, dataBase.getConnection());
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                FillDataGrid("");
                ColorDataGrid();

            }
        }
    }
}
