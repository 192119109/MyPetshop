using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PetShop
{
    class ChangeTextColor
    {
        public static void ChangeColor(RichTextBox rtx, int Start, byte Length = 1)
        {
            rtx.SelectionAlignment = HorizontalAlignment.Left;
            rtx.SelectionStart = Start;
            rtx.SelectionLength = Length;
            rtx.SelectionColor = Color.Crimson;
        }
    }
}
