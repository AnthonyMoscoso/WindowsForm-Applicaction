using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Library.Events
{
    public class ChangedControlSize
    {
        public static void ResizeControl(Control control,int with1, int with2)
        {
            if (control.Width == with1)
            {
                control.Width = with2;
            }
            else
            {
                control.Width = with1;
            }
        }
    }
}
