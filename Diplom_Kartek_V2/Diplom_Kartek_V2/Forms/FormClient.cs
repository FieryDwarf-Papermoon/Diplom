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
    public partial class FormClient : Form
    {

        private System.Windows.Forms.DataGridViewColumn COL;

        private string stringFiltor = "";

        private System.Windows.Forms.DataGridView dataGridView = null;
        public FormClient()
        {
            InitializeComponent();
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

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.ViewFiltor_Email_Client". При необходимости она может быть перемещена или удалена.
            this.viewFiltor_Email_ClientTableAdapter.Fill(this.diplomDataSet.ViewFiltor_Email_Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.ViewFiltor_Data_Client". При необходимости она может быть перемещена или удалена.
            this.viewFiltor_Data_ClientTableAdapter.Fill(this.diplomDataSet.ViewFiltor_Data_Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.View_Client". При необходимости она может быть перемещена или удалена.
            this.view_ClientTableAdapter.Fill(this.diplomDataSet.View_Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.diplomDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.diplomDataSet.Account);

            LoadTheme();
            panelLine.BackColor = ThemeColor.PrimaryColor;

            dataGridView = view_ClientDataGridView;
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
                    stringFiltor = "phone_Client";
                    comboBoxFiltor.DataSource = clientBindingSource;
                    comboBoxFiltor.DisplayMember = "phone_Client";
                    break;
                case 2:
                    stringFiltor = "email_Client";
                    comboBoxFiltor.DataSource = viewFiltorEmailClientBindingSource;
                    comboBoxFiltor.DisplayMember = "email_Client";
                    break;
                case 3:
                    stringFiltor = "Addres_Client";
                    comboBoxFiltor.DataSource = clientBindingSource;
                    comboBoxFiltor.DisplayMember = "Addres_Client";
                    break;
                case 4:
                    stringFiltor = "AllCount_Uslug";
                    comboBoxFiltor.DataSource = clientBindingSource;
                    comboBoxFiltor.DisplayMember = "AllCount_Uslug";
                    break;
                case 5:
                    stringFiltor = "AllSpentMoney";
                    comboBoxFiltor.DataSource = clientBindingSource;
                    comboBoxFiltor.DisplayMember = "AllSpentMoney";
                    break;
                case 6:
                    stringFiltor = "Restration_Client";
                    comboBoxFiltor.DataSource = viewFiltorDataClientBindingSource;
                    comboBoxFiltor.DisplayMember = "Restration_Client";
                    break;

                default:
                    break;
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
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    COL = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    COL = dataGridViewTextBoxColumn8;
                    break;
            }

            if (!radioButton1.Checked)
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonUpdData_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormUpdDataClient());
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

        private void buttonFiltor_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltor.Text.Length <= 0)
            {
                view_ClientBindingSource.Filter = stringFiltor + " is null";
                
            }
            else
            {
                if (stringFiltor == "Restration_Client")
                {
                    DateTime dateTime = Convert.ToDateTime(comboBoxFiltor.Text);
                    view_ClientBindingSource.Filter = String.Format("{2} >= '{0:yyyy-MM-dd}' AND {2} < '{1:yyyy-MM-dd}'", dateTime, dateTime.AddDays(1), stringFiltor);
                }
                else
                {
                    view_ClientBindingSource.Filter = stringFiltor + "= '" + comboBoxFiltor.Text.ToString() + "'";
                }
               
            }
        }

        private void buttonNoFiltor_Click(object sender, EventArgs e)
        {
            view_ClientBindingSource.Filter = "";
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i < dataGridView.RowCount - 1; i++)
            {
                for (j = 0; j < dataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
