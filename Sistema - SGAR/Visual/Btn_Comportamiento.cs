using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Visual {
    public class Btn_Comportamiento {
        public void activaboton (Object sender) {
            IconButton senderbtn = (IconButton)sender;
            senderbtn.ForeColor = Color.RoyalBlue;
            senderbtn.IconColor = Color.RoyalBlue;
        }

        public void desactivaboton (Object sender) {
            IconButton senderbtn = (IconButton)sender;
            senderbtn.ForeColor = Color.FromArgb (16, 42, 94);
            senderbtn.IconColor = Color.FromArgb (16, 42, 94);
        }

        public void activabotonPer (Object sender, Color color) {
            IconButton senderbtn = (IconButton)sender;
            senderbtn.ForeColor = color;
            senderbtn.IconColor = color;
        }
    }
}
