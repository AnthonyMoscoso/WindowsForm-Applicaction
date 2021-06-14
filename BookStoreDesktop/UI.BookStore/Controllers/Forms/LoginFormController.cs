using Domain.Dto.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.BookStore.Forms;

namespace UI.BookStore.Controllers
{
    public class LoginFormController
    {
        public delegate void Login(UserDto userDto);
        public Login _login;
        public LoginForm _form;
        public LoginFormController(LoginForm form)
        {
            _form = form;
            _form.btnLogin.MouseClick += ButtonLogin_MouseClick;
        
        }

        private void ButtonLogin_MouseClick(object sender, MouseEventArgs e)
        {
            UserDto user = new UserDto()
            {
                IdUser = 1,
                Username = _form.txtUserName.Text,
                PassWord = _form.txtPassWord.Text
            }; 
            _login?.Invoke(user);
        }


    }
}
