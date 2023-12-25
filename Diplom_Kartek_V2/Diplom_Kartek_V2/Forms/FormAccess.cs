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
    public partial class FormAccess : Form
    {
        public FormAccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Login = textBox1.Text;
                string Password = textBox2.Text;

                bool TrueLogin = false;

                DataTable dataTable = this.diplomDataSet.Account;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string Data_Login = dataTable.Rows[i]["Login_Account"].ToString().Trim();
                    string Data_Password = dataTable.Rows[i]["Passrole_Account"].ToString().Trim();

                    if (Data_Login == Login && Data_Password == Password)
                    {
                        TrueLogin = true;
                        MessageBox.Show("Вы успешно вошли!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        OpenAccount(Convert.ToInt32(dataTable.Rows[i]["LevelOpen_Account"]), Data_Login);
                    }


                }
                if (!TrueLogin)
                {
                    MessageBox.Show("Не правильный вход", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка: " + error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExitUser_Click(object sender, EventArgs e)
        {
            LordofForm.PowerAccess = 0;
            LordofForm.NameUser = "";
            LordofForm.TrueAccount = false;

            panel1.Visible = true;
            panelUser.Visible = false;
            panel3.Visible = true;

            LordofForm.MotherForm.CloseAccount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormRegisrt());
        }

        private void FormAccess_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.diplomDataSet.Account);
            LoadTheme();
            this.BackColor = ThemeColor.BackGroundForm;
            if (LordofForm.TrueAccount)
            {
                OpenAccount(LordofForm.PowerAccess, LordofForm.NameUser);
            }

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

        private void OpenAccount(int LP, string Us)
        {
            panelUser.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;

            labelUser.Text = "Пользователь: " + Us;

            LordofForm.PowerAccess = LP;
            LordofForm.NameUser = Us;
            LordofForm.TrueAccount = true;

            switch (LP)
            {
                case 1: labelPoverUser.Text = "Уровень доступа: Админ"; ; break;
                case 2: labelPoverUser.Text = "Уровень доступа: Бугалтер"; ; break;
                case 3: labelPoverUser.Text = "Уровень доступа: Гость"; ; break;
            }

            LordofForm.MotherForm.ActiveAccount();
        }

    }
}
