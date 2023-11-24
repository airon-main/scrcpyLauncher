using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrcpyLauncher
{
    internal class ColorPalette
    {
        public static Color primary = ColorTranslator.FromHtml("#30dd81");
        public static Color secondary = ColorTranslator.FromHtml("#077063");
        public static Color disabled = ColorTranslator.FromHtml("#888888");
        public static Color background = ColorTranslator.FromHtml("#dff7ea");
        public static Color carddark = ColorTranslator.FromHtml("#ffffff");
        public static Color card = ColorTranslator.FromHtml("#f2f2f2");
        public static Color text = ColorTranslator.FromHtml("#000000");

        public static void toggleDarkMode()
        {
            background = ColorTranslator.FromHtml("#1b1b1b");
            carddark = ColorTranslator.FromHtml("#222222");
            card = ColorTranslator.FromHtml("#292929");
            text = ColorTranslator.FromHtml("#ffffff");
        }

        public static void toggleLightMode()
        {
            background = ColorTranslator.FromHtml("#dff7ea");
            carddark = ColorTranslator.FromHtml("#ffffff");
            card = ColorTranslator.FromHtml("#f2f2f2");
            text = ColorTranslator.FromHtml("#000000");
        }
    }
}
