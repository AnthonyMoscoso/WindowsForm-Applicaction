using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Library.Reciclers.Views
{
    public partial class EnumAdapterView : AdapterView
    {
        private int i;
        public EnumAdapterView()
        {
            InitializeComponent();
        }

        public override void Draw(object o)
        {
            int n = Convert.ToInt32(o);
            this.Paint += Panel1_Paint;
            n *=2 ;
            i = n;
            label1.Text = $"{i + 3}";
        
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            i = i == 0 ? 1 : i;
            Color color_top = Color.FromArgb(12 * i > 255? 255 : 5*i, 9 * i > 255 ? 255 : 5 * i, 100 + i);
            Color color_down = Color.FromArgb(12 * i > 255 ? 255 : 5 * i, 11 * i > 255 ? 255 : 5 * i, 12 * i > 255 ? 255 : 5 * i);
            label1.BackColor = Color.Transparent;
            this.Paint += Panel1_Paint;
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, color_top, color_down, 60F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
         
        }
    }
}
