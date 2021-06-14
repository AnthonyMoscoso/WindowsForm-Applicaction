namespace UI.Library.Reciclers.Views
{
    public partial class StringAdapterView : AdapterView 
    {
        public StringAdapterView()
        {
            InitializeComponent();
        }

        public override void Draw(object o) {

            lbData.Text = o.ToString();
        }
    }
}
