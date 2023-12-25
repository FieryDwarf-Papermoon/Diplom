using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Diplom_Kartek_V2.Forms
{
    public partial class FormWorked : Form
    {
        public FormWorked()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private System.Windows.Forms.DataGridView dataGridView = null;

        private string stringFiltor = "";

        private void FormWorked_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.ViewFiltor_Data_Worked". При необходимости она может быть перемещена или удалена.
            this.viewFiltor_Data_WorkedTableAdapter.Fill(this.diplomDataSet.ViewFiltor_Data_Worked);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.diplomDataSet.Otdel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diplomDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Worked". При необходимости она может быть перемещена или удалена.
            this.workedTableAdapter.Fill(this.diplomDataSet.Worked);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.View_Worked". При необходимости она может быть перемещена или удалена.
            this.view_WorkedTableAdapter.Fill(this.diplomDataSet.View_Worked);

            LoadTheme();
            this.BackColor = ThemeColor.BackGroundForm;
            panelLine.BackColor = ThemeColor.PrimaryColor;

            dataGridView = view_WorkedDataGridView;
            LoadAccess();
        }

        private void LoadAccess()
        {
            if (LordofForm.PowerAccess < 3)
            {
                BtnUpdData.Enabled = true;
            }
            else
            {
                BtnUpdData.Enabled = false;
            }
        }

        private void LoadTheme()
        {
            this.BackColor = ThemeColor.BackGroundForm;
            foreach (Control Btns in this.Controls)
            {
                LoadForm.ColorUIForm(Btns);

                if (Btns.GetType() == typeof(Panel))
                {

                    foreach (Control BtnsZero in Btns.Controls)
                    {
                        LoadForm.ColorUIForm(BtnsZero);

                        if (BtnsZero.GetType() == typeof(Panel))
                        {

                            foreach (Control BtnsOne in BtnsZero.Controls)
                            {
                                LoadForm.ColorUIForm(BtnsOne);
                            }
                        }
                        if (BtnsZero.GetType() == typeof(GroupBox))
                        {

                            foreach (Control BtnsOne in BtnsZero.Controls)
                            {
                                LoadForm.ColorUIForm(BtnsOne);

                            }
                        }
                    }
                }
            }
        }

        private void buttonUpdData_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormUpdDataWorked());
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    COL = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    COL = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    COL = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    COL = dataGridViewTextBoxColumn10;
                    break;
            }

            if (!radioButton1.Checked)
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSort.Enabled = true;
        }

        private void comboBoxTypeFiltor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeFiltor.SelectedIndex)
            {
                case 0:
                    stringFiltor = "Name_Worked";
                    comboBoxFiltor.DataSource = workedBindingSource;
                    comboBoxFiltor.DisplayMember = "Name_Worked";
                    break;
                case 1:
                    stringFiltor = "NameDad_Worked";
                    comboBoxFiltor.DataSource = workedBindingSource;
                    comboBoxFiltor.DisplayMember = "NameDad_Worked";
                    break;
                case 2:
                    stringFiltor = "Familia_Worked";
                    comboBoxFiltor.DataSource = workedBindingSource;
                    comboBoxFiltor.DisplayMember = "Familia_Worked";
                    break;
                case 3:
                    stringFiltor = "phone_Worked";
                    comboBoxFiltor.DataSource = workedBindingSource;
                    comboBoxFiltor.DisplayMember = "phone_Worked";
                    break;
                case 4:
                    stringFiltor = "email_Worked";
                    comboBoxFiltor.DataSource = workedBindingSource;
                    comboBoxFiltor.DisplayMember = "email_Worked";
                    break;
                case 5:
                    stringFiltor = "Addres_Worked";
                    comboBoxFiltor.DataSource = workedBindingSource;
                    comboBoxFiltor.DisplayMember = "Addres_Worked";
                    break;
                case 6:
                    stringFiltor = "Title_Otdel";
                    comboBoxFiltor.DataSource = otdelBindingSource;
                    comboBoxFiltor.DisplayMember = "Title_Otdel";
                    break;
                case 7:
                    stringFiltor = "Title_Gender";
                    comboBoxFiltor.DataSource = genderBindingSource;
                    comboBoxFiltor.DisplayMember = "Title_Gender";
                    break;
                case 8:
                    stringFiltor = "Restration_Worked";
                    comboBoxFiltor.DataSource = viewFiltorDataWorkedBindingSource;
                    comboBoxFiltor.DisplayMember = "Restration_Worked";
                    break;

                default:
                    break;
            }
        }

        private void buttonFiltor_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltor.Text.Length <= 0)
            {
                view_WorkedBindingSource.Filter = stringFiltor + " is null";

            }
            else
            {
                if (stringFiltor == "Restration_Worked")
                {
                    DateTime dateTime = Convert.ToDateTime(comboBoxFiltor.Text);
                    view_WorkedBindingSource.Filter = String.Format("{2} >= '{0:yyyy-MM-dd}' AND {2} < '{1:yyyy-MM-dd}'", dateTime, dateTime.AddDays(1), stringFiltor);
                }
                else
                {
                    view_WorkedBindingSource.Filter = stringFiltor + "= '" + comboBoxFiltor.Text.ToString() + "'";
                }

            }
        }

        private void buttonNoFiltor_Click(object sender, EventArgs e)
        {
            view_WorkedBindingSource.Filter = "";
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount - 1; j++)
                {
                    dataGridView[i, j].Style.BackColor = Color.White;
                    dataGridView[i, j].Style.ForeColor = Color.Black;

                    if (dataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridView[i, j].Style.BackColor = Color.Red;
                        dataGridView[i, j].Style.ForeColor = Color.Yellow;
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount - 1; j++)
                {
                    dataGridView[i, j].Style.BackColor = Color.White;
                    dataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
        }

        private void OpenpoLevel()
        {
            if (LordofForm.PowerAccess < 3)
            {
                BtnUpdData.Enabled = true;
            }
            else
            {
                BtnUpdData.Enabled = false;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i < view_WorkedDataGridView.RowCount - 1; i++)
            {
                for (j = 0; j < view_WorkedDataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = view_WorkedDataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
