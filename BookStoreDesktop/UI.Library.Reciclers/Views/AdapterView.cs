using System;
using System.Windows.Forms;

namespace UI.Library.Reciclers.Views
{
    public   partial class AdapterView : UserControl 
    {

        public delegate void Selected(object entity);
        public Selected GetSelected;

        private object _entity;


        public AdapterView()
        {
            InitializeComponent();
        }

        public virtual void SetValue<T>(T entity)
        {
            _entity = entity;
            Click += Selected_Click;
        }
        public void Selected_Click(object sender,EventArgs e)
        {
            GetSelected?.Invoke(_entity);
        }

        public virtual void Draw(object o) { }

    }
}
