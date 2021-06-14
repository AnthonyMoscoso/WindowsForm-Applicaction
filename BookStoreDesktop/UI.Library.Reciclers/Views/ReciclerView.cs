using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Library.Reciclers.Specifics;

namespace UI.Library.Reciclers.Views
{
    public partial class ReciclerView : UserControl
    {

        public ReciclerView()
        {
            InitializeComponent();
        }

        public void AddAdapter(AdapterView adapter)
        {
            pnContainer.Controls.Add(adapter);
        }


        public void Clear()
        {
            pnContainer.Controls.Clear();
        }
    }
}
