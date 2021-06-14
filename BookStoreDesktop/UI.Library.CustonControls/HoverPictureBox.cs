using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Library.CustonControls
{
    public class HoverPictureBox : PictureBox
    {

        /// <summary>
        ///  Image with start
        /// </summary>
        public Image ImageInicial;

        /// <summary>
        ///  Bool that return is we want that image change when over
        /// </summary>
        public bool Hover { get; set; }
        public bool Clicked { get; set; }
        public Padding MarginIn { get; set; }
        public Image ImageHover { get; set; }
        public Padding MargingOut { get; set; }
        public HoverPictureBox()
        {

            MouseEnter += PictureHover_MouseEnter;
            MouseLeave += PictureHover_MouseLeave;
            MouseClick += PictureHover_MouseClick;
            SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void PictureHover_MouseClick(object sender, MouseEventArgs e)
        {
            if (Clicked)
            {
                if (Image == ImageHover)
                {
                    Image = ImageInicial;
                }
                else
                {
                    Image = ImageHover;
                }
            }

        }

        private void PictureHover_MouseLeave(object sender, EventArgs e)
        {
            if (Hover)
            {
                if (ImageInicial != null && !Clicked)
                {
                    Image = ImageInicial;

                }
                if (MarginIn == null)
                {
                    Margin = new Padding(6);
                }
                else
                {
                    Margin = MarginIn;
                }


            }


        }

        private void PictureHover_MouseEnter(object sender, EventArgs e)
        {
            MarginIn = Margin;
            if (ImageInicial == null)
            {
                ImageInicial = Image;
            }
            if (Hover)
            {
                if (ImageHover != null && !Clicked)
                {
                    Image = ImageHover;
                }
                if (MargingOut == null)
                {
                    Margin = new Padding(3);
                }
                else
                {
                    Margin = MargingOut;
                }


            }

        }
    }
}