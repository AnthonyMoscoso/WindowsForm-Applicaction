
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Library.Events
{
    public class WindowsControls
    {

        public static void BtnClose_CloseWindonw(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            CloseWindown(control);
        }

        public static void BtnMinize_MinimizeWindown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            MinimizedWindown(control);
        }

        public static void BtnMinize_ResizeWindown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            ResizeWindown(control);
        }

        private static void CloseWindown(Control sender)
        {
          
            if (sender.Parent != null)
            {
                CloseWindown(sender.Parent);
            }
            else
            {
                sender.Dispose();
            }
        }

        private static void ResizeWindown(Control sender)
        {
            if (sender.Parent != null)
            {
                ResizeWindown(sender.Parent);
            }
            else
            {
                Form form = sender as Form;
                if(form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                else if (form.WindowState == FormWindowState.Normal)
                {
                    form.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private static void MinimizedWindown(Control sender)
        {
            if (sender.Parent != null)
            {
                MinimizedWindown(sender.Parent);
            }
            else
            {
                Form form = sender as Form;
                form.WindowState = FormWindowState.Minimized;
            }
        }


    }
}
