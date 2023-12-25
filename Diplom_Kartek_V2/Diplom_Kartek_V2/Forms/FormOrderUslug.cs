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
    public partial class FormOrderUslug : Form
    {
        public FormOrderUslug()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private System.Windows.Forms.DataGridView dataGridView = null;

        private string stringFiltor = "";

        private void FormOrderUslug_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.ViewFiltor_Data_OrdenUslug". При необходимости она может быть перемещена или удалена.
            this.viewFiltor_Data_OrdenUslugTableAdapter.Fill(this.diplomDataSet.ViewFiltor_Data_OrdenUslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.ViewFiltor_Complect_OrdenUslug". При необходимости она может быть перемещена или удалена.
            this.viewFiltor_Complect_OrdenUslugTableAdapter.Fill(this.diplomDataSet.ViewFiltor_Complect_OrdenUslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Uslug". При необходимости она может быть перемещена или удалена.
            this.uslugTableAdapter.Fill(this.diplomDataSet.Uslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.diplomDataSet.Otdel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.diplomDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.View_Order_Uslug". При необходимости она может быть перемещена или удалена.
            this.view_Order_UslugTableAdapter.Fill(this.diplomDataSet.View_Order_Uslug);

            LoadTheme();

            panelLine.BackColor = ThemeColor.PrimaryColor;

            dataGridView = view_Order_UslugDataGridView;
            LoadAccess();
        }

        private void LoadAccess()
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
                case 4:
                    COL = dataGridViewTextBoxColumn5;
                    break;
            }

            if (!radioButton1.Checked)
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonUpdData_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormUpdDataOrderUslug());
        }

        private void buttonFiltor_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltor.Text.Length <= 0)
            {
                view_Order_UslugBindingSource.Filter = stringFiltor + " is null";

            }
            else
            {
                if (stringFiltor == "Restration_Order_Uslug")
                {
                    DateTime dateTime = Convert.ToDateTime(comboBoxFiltor.Text);
                    view_Order_UslugBindingSource.Filter = String.Format("{2} >= '{0:yyyy-MM-dd}' AND {2} < '{1:yyyy-MM-dd}'", dateTime, dateTime.AddDays(1), stringFiltor);
                }
                else
                {
                    view_Order_UslugBindingSource.Filter = stringFiltor + "= '" + comboBoxFiltor.Text.ToString() + "'";
                }

            }
        }

        private void buttonNoFiltor_Click(object sender, EventArgs e)
        {
            view_Order_UslugBindingSource.Filter = "";
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i < view_Order_UslugDataGridView.RowCount - 1; i++)
            {
                for (j = 0; j < view_Order_UslugDataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = view_Order_UslugDataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void comboBoxTypeFiltor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeFiltor.SelectedIndex)
            {
                case 0:
                    stringFiltor = "Name_Client";
                    comboBoxFiltor.DataSource = clientBindingSource;
                    comboBoxFiltor.DisplayMember = "Name_Client";
                    break;
                case 1:
                    stringFiltor = "Title_Uslug";
                    comboBoxFiltor.DataSource = uslugBindingSource;
                    comboBoxFiltor.DisplayMember = "Title_Uslug";
                    break;
                case 2:
                    stringFiltor = "Title_Otdel";
                    comboBoxFiltor.DataSource = otdelBindingSource;
                    comboBoxFiltor.DisplayMember = "Title_Otdel";
                    break;
                case 3:
                    stringFiltor = "Completed_Order_Uslug";
                    comboBoxFiltor.DataSource = viewFiltorComplectOrdenUslugBindingSource;
                    comboBoxFiltor.DisplayMember = "Completed_Order_Uslug";
                    break;
                case 4:
                    stringFiltor = "Restration_Order_Uslug";
                    comboBoxFiltor.DataSource = viewFiltorDataOrdenUslugBindingSource;
                    comboBoxFiltor.DisplayMember = "Restration_Order_Uslug";
                    break;


                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
