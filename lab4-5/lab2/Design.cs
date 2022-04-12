using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab4
{
    [Serializable]
    public class Design
    {
        private static Design instance;
        public string Background { get; private set; }
        public string Font { get; private set; }
        public string TextColor { get; private set; }

        protected Design (string background, string font, string textColor)
        {
            this.Background = background;
            this.Font = font;
            this.TextColor = textColor;
        }

        public static Design GetInstance(string background, string font, string textColor)
        {
            if (instance == null)
                instance = new Design(background, font, textColor);
            return instance;
        }
    }
}
