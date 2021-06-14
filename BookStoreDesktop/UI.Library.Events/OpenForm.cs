using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Library.Events
{
    public class OpenForm
    {
        public static void OpenFormInPanel(Panel panel,Form form)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
                panel.Controls.Clear();

            }
            Form formSon = form as Form;
            formSon.TopLevel = false;
            formSon.Dock = DockStyle.Fill;
            panel.Controls.Add(formSon);
            panel.Tag = formSon;
            formSon.Show();
        }
    }
}
