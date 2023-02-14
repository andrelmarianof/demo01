using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01.Views.Helpers
{
   public static class TextBoxEventHelpers
    {
        public static void KeyPressNumericHandler(TextBox sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
