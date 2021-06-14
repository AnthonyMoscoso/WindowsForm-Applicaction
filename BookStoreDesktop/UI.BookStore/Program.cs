using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.BookStore.Controllers;

namespace UI.BookStore
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FormBase formBase = new FormBase();
            BaseController controller = new BaseController(formBase);
            Application.Run(formBase);
        }
    }
}
