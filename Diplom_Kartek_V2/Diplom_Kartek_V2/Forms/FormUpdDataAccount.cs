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
    public partial class FormUpdDataAccount : Form
    {
        public FormUpdDataAccount()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.BindingSource bindingSource;

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }

        private void FormUpdDataAccount_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.LevelOpen". При необходимости она может быть перемещена или удалена.
            this.levelOpenTableAdapter.Fill(this.diplomDataSet.LevelOpen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.diplomDataSet.Account);
            LoadTheme();
            bindingSource = accountBindingSource;           
            panelLine.BackColor = ThemeColor.PrimaryColor;
            AdminAccount();
        }

        private void AdminAccount()
        {
            if (Convert.ToInt32(iD_AccountTextBox.Text) == 1)
            {
                login_AccountTextBox.ReadOnly = true;
                passrole_AccountTextBox.ReadOnly = true;
                comboBox1.Enabled = false;
            }
            else
            {
                login_AccountTextBox.ReadOnly = false;
                passrole_AccountTextBox.ReadOnly = false;
                comboBox1.Enabled = true;
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

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(iD_AccountTextBox.Text) != 1)
            {
                bindingSource.RemoveCurrent();
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
            AdminAccount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
            AdminAccount();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
            AdminAccount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
            AdminAccount();
        }
    }
}
