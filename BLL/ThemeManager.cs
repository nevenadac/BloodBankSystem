using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection.BLL
{
    public static class ThemeManager
    {
        public static Theme CurrentTheme { get; private set; } = Themes.LightTheme;

        public static event Action ThemeChanged;

        public static void ApplyTheme(Form form)
        {
            ApplyThemeToControl(form, CurrentTheme);
        }

        public static void SetTheme(string themeName)
        {
            switch (themeName)
            {
                case "White":
                    CurrentTheme = Themes.LightTheme;
                    break;
                case "Black":
                    CurrentTheme = Themes.DarkTheme;
                    break;
                case "Blue":
                    CurrentTheme = Themes.BlueTheme;
                    break;
                default:
                    CurrentTheme = Themes.LightTheme;
                    break;
            }

            ThemeChanged?.Invoke();
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
