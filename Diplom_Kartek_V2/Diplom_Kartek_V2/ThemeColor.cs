using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Kartek_V2
{
    public static class ThemeColor
    {
        public static Color OriginalColor { get; set; }
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static Color BackGroundForm { get; set; }
        public static bool BlackThemeForm { get; set; }

        public static int SizeFore { get; set; }

        public static List<string> ColorList = new List<string>() {"#3F51B5",
                                                                   "#009688",
                                                                   "#FF5722",
                                                                   "#607D8B",
                                                                   "#9C27B0",
                                                                   "#2196F3",
                                                                   "#EA676C",
                                                                   "#E41A4A",
                                                                   "#5978BB",
                                                                   "#00B0AD",
                                                                   "#018790",
                                                                   "#0094BC",
                                                                   "#C7DC5B",
                                                                   "#E4126B",
                                                                   "#43B76E",
                                                                   "#7BCFE9",
                                                                   "#B71C46",
                                                                   "#721D47",
                                                                   "#EA4833",
                                                                   "#EF7521",
                                                                   "#A12059"};

        public static void SelectPrymaryAndSecondaryColor(Color color)
        {
            if (ThemeColor.BlackThemeForm)
            {
                ThemeColor.PrimaryColor = ThemeColor.ChangeColorBrightness(color, 0.6);
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, 0.3);
            }
            else
            {
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            }
            OriginalColor = color;
        }

        public static void SelectThemeForm(bool themeBlack)
        {
            if (themeBlack)
            {
                BackGroundForm = Color.FromArgb(60, 60, 60);
            }
            else
            {
                BackGroundForm = Color.WhiteSmoke;
            }
            BlackThemeForm = themeBlack;
        }

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
