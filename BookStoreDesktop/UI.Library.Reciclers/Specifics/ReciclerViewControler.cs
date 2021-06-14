using UI.Library.Reciclers.Views;

namespace UI.Library.Reciclers.Specifics
{
    public class ReciclerViewControler 
    {
        ReciclerView _view;

        public delegate void Send(object o);
        public Send SelectedItem;
        public ReciclerViewControler()
        {
       
        }

        public void SetAdapter(ReciclerView view, AdapterViewControler adapterViewControler)
        {
            _view = view;
            foreach (AdapterView adapterView in adapterViewControler.adapters)
            {
                _view.AddAdapter(adapterView);
                adapterView.GetSelected += SelectedEntity;
            }
        }

        public void SelectedEntity(object o)
        {
            SelectedItem?.Invoke(o);
        }
    }
}
