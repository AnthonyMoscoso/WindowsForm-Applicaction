using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Library.CustonControls
{
    public partial class PaginatorCustomControl : UserControl
    {
        public int? Pages { get => Pages == null ? 1 : Pages; set { } }
        private int actualPage;
        public int? Elements { get; set; }
        public int? ElementForPage { get; set; }
        public delegate void GoTo(int pag);
        public GoTo _goToPag;
        public PaginatorCustomControl()
        {
            InitializeComponent();
            actualPage = 1;
            if (Pages == 1)
            {
                SetStatusButton(btnGoToBefore, false);
                SetStatusButton(btnGoToFirst, false);
                SetStatusButton(btnGoToLast, false);
                SetStatusButton(btnGoToNext, false);
            }
            else
            {
                btnGoToLast.MouseClick += BtnGoToLast_MouseClick;
                btnGoToFirst.MouseClick += BtnGoToFirst_MouseClick;
                btnGoToBefore.MouseClick += BtnGoToBefore_MouseClick;
                btnGoToNext.MouseClick += BtnGoToNext_MouseClick;
            }
            ElementForPage = ElementForPage == null ? 0 : ElementForPage;
            Elements = Elements == null ? 0 : Elements;
            lbTotalElements.Text =$"{ElementForPage*actualPage}/{Elements}" ;


        }



        private void BtnGoToNext_MouseClick(object sender, MouseEventArgs e)
        {
            if (actualPage < Pages)
            {
                actualPage++;
                _goToPag?.Invoke(actualPage);
                lbNumPag.Text = $"{actualPage}/{Pages}";
                lbTotalElements.Text = $"{ElementForPage * actualPage}/{Elements}";
            }

        }

        private void BtnGoToBefore_MouseClick(object sender, MouseEventArgs e)
        {
            if (actualPage > 1)
            {
                actualPage--;
                _goToPag?.Invoke(actualPage);
                lbTotalElements.Text = $"{ElementForPage * actualPage}/{Elements}";
            }
          
           
        }

        private void BtnGoToFirst_MouseClick(object sender, MouseEventArgs e)
        {
            if (actualPage > 1)
            {
                actualPage = 1;
                _goToPag?.Invoke(actualPage);
                lbNumPag.Text = $"{actualPage}/{Pages}";
            }
           
        }

        private void BtnGoToLast_MouseClick(object sender, MouseEventArgs e)
        {
            if (actualPage < Pages)
            {
                actualPage = Pages.Value;
                _goToPag?.Invoke(actualPage);
                lbTotalElements.Text = $"{ElementForPage * actualPage}/{Elements}";
            }
           
        }

        private void SetStatusButton(Button button, bool status)
        {
            button.Enabled = status;
        }
    }
}
