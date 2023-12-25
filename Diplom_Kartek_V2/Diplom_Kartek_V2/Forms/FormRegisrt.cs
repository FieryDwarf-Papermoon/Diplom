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
    public partial class FormRegisrt : Form
    {
        public FormRegisrt()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
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

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                string Login = login_AccountTextBox.Text;
                string Password = passrole_AccountTextBox.Text;

                bool TrueLogin = false;

                DataTable dataTable = this.diplomDataSet.Account;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string Data_Login = dataTable.Rows[i]["Login_Account"].ToString().Trim();
                    string Data_Password = dataTable.Rows[i]["Passrole_Account"].ToString().Trim();

                    if (Data_Login == Login)
                    {
                        TrueLogin = true;
                        MessageBox.Show("Такой логин уже существует!", "Логин уже существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                }
                if (!TrueLogin)
                {
                    this.Validate();
                    this.accountBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.diplomDataSet);
                    MessageBox.Show("Аккаунт успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LordofForm.MotherForm.FullReset();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка: " + error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void FormRegisrt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.diplomDataSet.Account);
            LoadTheme();
            this.BackColor = ThemeColor.BackGroundForm;
            accountBindingSource.AddNew();

        }
    }
}
