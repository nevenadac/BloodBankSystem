using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection.BLL;

namespace Connection.DAL
{
    public class ThemeAccess
    {
        public static void ApplyTheme(Form form, string themeName)
        {
            Theme selectedTheme;

            switch (themeName)
            {
                case "Yellow":
                    selectedTheme = Themes.LightTheme;
                    break;
                case "Black":
                    selectedTheme = Themes.DarkTheme;
                    break;
                case "Blue":
                    selectedTheme = Themes.BlueTheme;
                    break;
                default:
                    selectedTheme = Themes.LightTheme;
                    break;
            }

            form.BackColor = selectedTheme.BackgroundColor;
            form.ForeColor = selectedTheme.ForegroundColor;
            form.Font = selectedTheme.Font;

            foreach (Control control in form.Controls)
            {
                ApplyThemeToControl(control, selectedTheme);
            }
        }

        private static void ApplyThemeToControl(Control control, Theme theme)
        {
            control.BackColor = theme.BackgroundColor;
            control.ForeColor = theme.ForegroundColor;
            control.Font = theme.Font;

            foreach (Control childControl in control.Controls)
            {
                ApplyThemeToControl(childControl, theme);
            }
        }
    }
}
