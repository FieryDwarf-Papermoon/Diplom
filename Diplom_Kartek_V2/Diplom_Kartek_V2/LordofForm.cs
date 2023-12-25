using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Kartek_V2
{
    public static class LordofForm
    {
        public static FormMainMenu MotherForm { get; set; }
        public static Form ChildrenForm { get; set; }
        public static int PowerAccess { get; set; }
        public static string NameUser { get; set; }
        public static bool TrueAccount { get; set; }


        public static void StartApplication(FormMainMenu form)
        {
            MotherForm = form;
            PowerAccess = 0;
        }

        public static void OpenGrandChildForm(Form grandchildForm)
        {
            ChildrenForm = MotherForm.activeForm;
            //if (MotherForm.activeForm != null)
            //{
            //    MotherForm.activeForm.Close();
            //}
            MotherForm.activeForm = grandchildForm;
            grandchildForm.TopLevel = false;
            grandchildForm.FormBorderStyle = FormBorderStyle.None;
            grandchildForm.Dock = DockStyle.Fill;
            MotherForm.AddChildForm(grandchildForm);
            grandchildForm.BringToFront();
            grandchildForm.Show();

        }

        public static void CloseGrandChildForm()
        {
            if (MotherForm.activeForm != null)
            {
                MotherForm.activeForm.Close();
            }
            MotherForm.activeForm = ChildrenForm;
            ChildrenForm.TopLevel = false;
            ChildrenForm.FormBorderStyle = FormBorderStyle.None;
            ChildrenForm.Dock = DockStyle.Fill;
            MotherForm.AddChildForm(ChildrenForm);
            ChildrenForm.BringToFront();
            ChildrenForm.Show();
            ChildrenForm = null;
        }

        //public static void CloseAllChildForm()
        //{
        //    MotherForm.FullReset();
        //}

    }
}
