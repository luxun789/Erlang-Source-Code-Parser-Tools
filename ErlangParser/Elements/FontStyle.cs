using System.Drawing;

namespace ErlangParserLib.Elements
{
    public class FontStyle
    {
        public Color ForeColor {get; set;}
        public Color BackgroundColor {get; set;}
        public Font Font {get; set;}

        public FontStyle(Color forecolor, Color backgroundcolor, Font font)
        {
            this.ForeColor = forecolor;
            this.BackgroundColor = backgroundcolor;
            this.Font = font;
        }
    }
}
