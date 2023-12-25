using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Kartek_V2.Forms
{
    public partial class FormUpdDataOrderUslug : Form
    {
        public FormUpdDataOrderUslug()
        {
            InitializeComponent();
        }

        private void order_UslugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_UslugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }

        private System.Windows.Forms.BindingSource bindingSource;

        private void FormUpdDataOrderUslug_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.diplomDataSet.Otdel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.diplomDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Uslug". При необходимости она может быть перемещена или удалена.
            this.uslugTableAdapter.Fill(this.diplomDataSet.Uslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Order_Uslug". При необходимости она может быть перемещена или удалена.
            this.order_UslugTableAdapter.Fill(this.diplomDataSet.Order_Uslug);

            LoadTheme();
            bindingSource = order_UslugBindingSource;
            panelLine.BackColor = ThemeColor.PrimaryColor;
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

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
        }
    }
}
