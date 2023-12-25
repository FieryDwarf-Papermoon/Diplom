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
    public partial class FormOtdel : Form
    {
        public FormOtdel()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private System.Windows.Forms.DataGridView dataGridView = null;

        private string stringFiltor = "";

        private void otdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }

        private void FormOtdel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.ViewFiltor_Data_Otdel". При необходимости она может быть перемещена или удалена.
            this.viewFiltor_Data_OtdelTableAdapter.Fill(this.diplomDataSet.ViewFiltor_Data_Otdel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.diplomDataSet.Otdel);

            LoadTheme();

            panelLine.BackColor = ThemeColor.PrimaryColor;

            dataGridView = otdelDataGridView;
            LoadAccess();
        }

        private void LoadAccess()
        {
            if (LordofForm.PowerAccess < 2)
            {
                buttonUpdData.Enabled = true;
            }
            else
            {
                buttonUpdData.Enabled = false;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSort.Enabled = true;
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
            }

            if (!radioButton1.Checked)
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonFiltor_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltor.Text.Length <= 0)
            {
                otdelBindingSource.Filter = stringFiltor + " is null";

            }
            else
            {
                if (stringFiltor == "Restration_Otdel")
                {
                    DateTime dateTime = Convert.ToDateTime(comboBoxFiltor.Text);
                    otdelBindingSource.Filter = String.Format("{2} >= '{0:yyyy-MM-dd}' AND {2} < '{1:yyyy-MM-dd}'", dateTime, dateTime.AddDays(1), stringFiltor);
                }
                else
                {
                    otdelBindingSource.Filter = stringFiltor + "= '" + comboBoxFiltor.Text.ToString() + "'";
                }

            }
        }

        private void buttonNoFiltor_Click(object sender, EventArgs e)
        {
            otdelBindingSource.RemoveFilter();
        }

        private void comboBoxTypeFiltor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeFiltor.SelectedIndex)
            {
                case 0:
                    stringFiltor = "Title_Otdel";
                    comboBoxFiltor.DataSource = otdelBindingSource;
                    comboBoxFiltor.DisplayMember = "Title_Otdel";
                    break;
                case 1:
                    stringFiltor = "Count_Workers_Otdel";
                    comboBoxFiltor.DataSource = otdelBindingSource;
                    comboBoxFiltor.DisplayMember = "Count_Workers_Otdel";
                    break;
                case 2:
                    stringFiltor = "Popular_Otdel";
                    comboBoxFiltor.DataSource = otdelBindingSource;
                    comboBoxFiltor.DisplayMember = "Popular_Otdel";
                    break;
                case 3:
                    stringFiltor = "Restration_Otdel";
                    comboBoxFiltor.DataSource = viewFiltorDataOtdelBindingSource;
                    comboBoxFiltor.DisplayMember = "Restration_Otdel";
                    break;

                default:
                    break;
            }
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

        private void OpenpoLevel()
        {
            if (LordofForm.PowerAccess < 3)
            {
                buttonUpdData.Enabled = true;
            }
            else
            {
                buttonUpdData.Enabled = false;
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i < otdelDataGridView.RowCount - 1; i++)
            {
                for (j = 0; j < otdelDataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = otdelDataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void buttonUpdData_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormUpdDataOtdel());
        }

        private void comboBoxFiltor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
