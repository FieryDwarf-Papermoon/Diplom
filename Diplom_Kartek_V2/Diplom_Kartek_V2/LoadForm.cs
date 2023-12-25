using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Diplom_Kartek_V2
{
    public static class LoadForm
    {
        public static void ColorUIForm(Control Btns)
        {
            if (Btns.GetType() == typeof(Button))
            {
                Button previousBtn = (Button)Btns;
                previousBtn.BackColor = ThemeColor.PrimaryColor;
                previousBtn.ForeColor = Color.White;
                previousBtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            }

            if (Btns.GetType() == typeof(Label))
            {
                Label previousLbl = (Label)Btns;
                previousLbl.ForeColor = ThemeColor.SecondaryColor;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }

            if (Btns.GetType() == typeof(RadioButton))
            {
                RadioButton previousLbl = (RadioButton)Btns;
                previousLbl.ForeColor = ThemeColor.PrimaryColor;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }

            if (Btns.GetType() == typeof(GroupBox))
            {
                GroupBox previousLbl = (GroupBox)Btns;
                previousLbl.ForeColor = ThemeColor.PrimaryColor;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }

            if (Btns.GetType() == typeof(TextBox))
            {
                TextBox previousLbl = (TextBox)Btns;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }

            if (Btns.GetType() == typeof(ComboBox))
            {
                ComboBox previousLbl = (ComboBox)Btns;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }

            if (Btns.GetType() == typeof(ListBox))
            {
                ListBox previousLbl = (ListBox)Btns;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }

            if (Btns.GetType() == typeof(DataGridView))
            {
                DataGridView previousLbl = (DataGridView)Btns;
                previousLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", ThemeColor.SizeFore, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }
        }
    }
}
