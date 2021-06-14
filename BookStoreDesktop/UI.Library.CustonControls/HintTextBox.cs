using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Library.Events;

namespace UI.Library.CustonControls
{
    public class HintTextBox : TextBox
    {
        public string HintText { get; set; }
        public enum TipeText
        {
            All, ONLY_NUMBERS, ONLY_LETTERS
        }
        public TipeText Tipo_De_Texto { get; set; }

        public bool IsEnty()
        {
            if (string.IsNullOrEmpty(HintText)  && !Text.Equals(HintText))
            {
                return false;
            }
            return true;
        }
        public HintTextBox()
        {

            Text = HintText;
            LostFocus += Add_Hint;
            HandleCreated += Add_Hint;
            MouseLeave += Add_Hint;
            MouseClick += Vaciar_hint;
            KeyDown += Vaciar_hint;
            ControlAdded += Vaciar_hint;
            KeyPress += HintText_KeyPress;
            TextChanged += HintText_TextChanged;

        }

        private void HintText_TextChanged(object sender, EventArgs e)
        {
            if (!Text.Equals(HintText))
            {
                ForeColor = Color.Black;
            }
        }

        private void HintText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tipo_De_Texto == TipeText.ONLY_LETTERS)
            {
                ValidateTxt.OnlyText(e);
            }
            else if (Tipo_De_Texto == TipeText.ONLY_NUMBERS)
            {
                ValidateTxt.DecimalNumber(e);
            }
        }

        public void Vaciar()
        {
            Text = HintText;
            ForeColor = Color.Gray;
        }
        public void Add_Hint(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Vaciar();
            }
        }
        private void Vaciar_hint(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = string.Empty;
                ForeColor = Color.Black;
            }

        }
    }
}
