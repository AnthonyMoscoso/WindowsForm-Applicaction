using Domain.Dto.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.BookStore.Forms;
using UI.Library.Events;

namespace UI.BookStore.Controllers
{
    public class ContainerFormController
    {
        public FormContainer _form;
        public ContainerFormController(FormContainer form)
        {
            _form = form;
            _form.ptbxMenuIcon.MouseClick += PtbxMenuIcon_MouseClick;
        
        }

        private void ButtonImageControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void PtbxMenuIcon_MouseClick(object sender, MouseEventArgs e)
        {
           ChangedControlSize.ResizeControl(_form.pnMenu,225,50);
 
        }
    

   

        public void SetUser(UserDto user)
        {
            //_form.txtUser.Text = user.ToString();
        }
    }
}
