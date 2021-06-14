using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.BookStore.Forms;

namespace UI.BookStore.Controllers.Forms
{
    public class MueblesFormController
    {
        FormStorePlaces _form;
        public MueblesFormController(FormStorePlaces form)
        {
            _form = form;
            _form.button1.MouseClick += Button1_MouseClick;
        }

        private void Button1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
          
        }
    }
}
