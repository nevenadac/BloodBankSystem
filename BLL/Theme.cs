using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Connection.BLL
{
    public class Theme
    {
        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public Font Font { get; set; }
    }

    public static class Themes
    {
        public static Theme LightTheme = new Theme
        {
            BackgroundColor = Color.Yellow,
            ForegroundColor = Color.Black,
            Font = new Font("Arial", 10)
        };

        public static Theme DarkTheme = new Theme
        {
            BackgroundColor = Color.Black,
            ForegroundColor = Color.White,
            Font = new Font("Times New Roman", 9)
        };

        public static Theme BlueTheme = new Theme
        {
            BackgroundColor = Color.LightBlue,
            ForegroundColor = Color.DarkBlue,
            Font = new Font("Arial", 8)
        };
    }


}
