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
    public partial class FormUslug : Form
    {
        public FormUslug()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private System.Windows.Forms.DataGridView dataGridView = null;

        private string stringFiltor = "";

        private void uslugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uslugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }

        private void FormUslug_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Uslug". При необходимости она может быть перемещена или удалена.
            this.uslugTableAdapter.Fill(this.diplomDataSet.Uslug);

            LoadTheme();
            panelLine.BackColor = ThemeColor.PrimaryColor;

            dataGridView = uslugDataGridView;
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
                buttonUpdData.Enabled=false;
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

            }

            if (!radioButton1.Checked)
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonUpdData_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormUpdataUslug());
        }

        private void buttonFiltor_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltor.Text.Length <= 0)
            {
                uslugBindingSource.Filter = stringFiltor + " is null";

            }
            else
            {
                
                uslugBindingSource.Filter = stringFiltor + "= '" + comboBoxFiltor.Text.ToString() + "'";
               

            }
        }

        private void buttonNoFiltor_Click(object sender, EventArgs e)
        {
            uslugBindingSource.Filter = "";
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
                buttonUpdData.Enabled = true;
            }
            else
            {
                buttonUpdData.Enabled = false;
            }
        }

        private void comboBoxTypeFiltor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeFiltor.SelectedIndex)
            {
                case 0:
                    stringFiltor = "Title_Uslug";
                    comboBoxFiltor.DataSource = uslugBindingSource;
                    comboBoxFiltor.DisplayMember = "Title_Uslug";
                    break;
                case 1:
                    stringFiltor = "Prise_Uslug";
                    comboBoxFiltor.DataSource = uslugBindingSource;
                    comboBoxFiltor.DisplayMember = "Prise_Uslug";
                    break;
                case 2:
                    stringFiltor = "Popular_Uslug";
                    comboBoxFiltor.DataSource = uslugBindingSource;
                    comboBoxFiltor.DisplayMember = "Popular_Uslug";
                    break;

                default:
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSort.Enabled = true;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i < uslugDataGridView.RowCount - 1; i++)
            {
                for (j = 0; j < uslugDataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = uslugDataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
