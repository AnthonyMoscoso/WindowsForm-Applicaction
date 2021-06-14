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
    public class BaseController
    {
        public FormBase _view;

        public BaseController(FormBase form)
        {
            _view = form;
            _view.pnTop.MouseDown += Movement.Pn_MouseDown;
            _view.btnClose.MouseClick += WindowsControls.BtnClose_CloseWindonw;
            _view.btnMin.MouseClick += WindowsControls.BtnMinize_MinimizeWindown;
            _view.btnResize.MouseClick += WindowsControls.BtnMinize_ResizeWindown;

            LoginForm loginForm = new LoginForm();
            LoginFormController loginFormController = new LoginFormController(loginForm);
            OpenForm.OpenFormInPanel(_view.pnBody,loginForm);
            loginFormController._login += Logg;
        }

        public void Logg(UserDto userDto)
        {
            FormContainer formContainer = new FormContainer();
            ContainerFormController containerFormController = new ContainerFormController(formContainer);
            OpenForm.OpenFormInPanel(_view.pnBody,formContainer);
            containerFormController.SetUser(userDto);
        }

        
    }
}
