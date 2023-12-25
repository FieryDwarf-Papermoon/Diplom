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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();


        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
            comboBox1.Text = ThemeColor.SizeFore.ToString();
            this.BackColor = ThemeColor.BackGroundForm;
            radioButtonBlackBack.Checked = ThemeColor.BlackThemeForm;


            if (LordofForm.PowerAccess == 1)
            {
                paSettingsAccount.Visible = true;
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

        private void buttonSelectSetting_Click(object sender, EventArgs e)
        {
            ThemeColor.SelectThemeForm(!radioButtonWhileBack.Checked);
            ThemeColor.SelectPrymaryAndSecondaryColor(ThemeColor.OriginalColor);
            ThemeColor.SizeFore = Convert.ToInt16(comboBox1.Text);
            LoadTheme();
            this.BackColor = ThemeColor.BackGroundForm;
        }

        private void buttonSettingsAccount_Click(object sender, EventArgs e)
        {
            LordofForm.OpenGrandChildForm(new Forms.FormUpdDataAccount());
        }
    }
}
