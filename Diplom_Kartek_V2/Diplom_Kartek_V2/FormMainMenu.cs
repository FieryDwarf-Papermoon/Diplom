using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Kartek_V2
{
    public partial class FormMainMenu : Form
    {
        private Button correntButton;
        private Random random;
        private int tempIndex;
        public Form activeForm;

        private int accessLevel = 0;

        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ThemeColor.BackGroundForm = Color.WhiteSmoke;
            ThemeColor.SizeFore = 10;
            this.BackColor = ThemeColor.BackGroundForm;

            LordofForm.StartApplication(this);

            CloseAccount();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParan, int lParan);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (correntButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    correntButton = (Button)btnSender;
                    correntButton.BackColor = color;
                    correntButton.ForeColor = Color.White;
                    correntButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.SelectPrymaryAndSecondaryColor(color);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSenter)
        {
            if (LordofForm.ChildrenForm != null)
            {
                LordofForm.ChildrenForm.Close();
                LordofForm.ChildrenForm = null;
            }
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSenter);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            AddChildForm(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void ActiveAccount()
        {
            if (LordofForm.PowerAccess > 0)
            {
                if (LordofForm.PowerAccess < 3)
                {
                    btnClient.Enabled = true;
                    btnWorked.Enabled = true;
                    btnGoingOrder.Enabled = true;
                    btnOtdel.Enabled = true;
                }

               
                btnUslug.Enabled = true;

            }
        }

        public void CloseAccount()
        {
            btnClient.Enabled = false;
            btnGoingOrder.Enabled = false;
            btnOtdel.Enabled = false;
            btnUslug.Enabled = false;
            btnWorked.Enabled = false;
        }

        public void AddChildForm(Form childForm)
        {
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            label1.Text = childForm.Text;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();

                if (LordofForm.ChildrenForm != null)
                {
                    LordofForm.CloseGrandChildForm();
                }
                else
                {
                    Reset();
                }
            }

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClient(), sender);
        }

        private void btnUslug_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUslug(), sender);
        }

        private void btnGoingOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrderUslug(), sender);
        }

        private void btnWorked_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormWorked(), sender);
        }

        private void btnOtdel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOtdel(), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAccess(), sender);
        }

        

        public void FullReset()
        {
            if (activeForm != null)
            {
                activeForm.Close();

                if (LordofForm.ChildrenForm != null)
                {
                    LordofForm.ChildrenForm.Close();
                }

                Reset();

            }
        }

        private void Reset()
        {
            DisableButton();
            label1.Text = "ГЛАВНАЯ";
            panelTitleBar.BackColor = Color.MediumPurple;
            panelLogo.BackColor = Color.FromArgb(40, 40, 65);
            correntButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
