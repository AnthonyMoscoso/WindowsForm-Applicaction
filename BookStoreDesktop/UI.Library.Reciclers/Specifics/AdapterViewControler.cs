using System;
using System.Collections.Generic;
using UI.Library.Reciclers.Views;

namespace UI.Library.Reciclers.Specifics
{
    public class AdapterViewControler
    {
        public delegate void Send(object entity);
        public Send GetSelectEntity;
        public List<AdapterView> adapters;
        private AdapterView _view;


        public delegate void sendSelected(object selected);
        public sendSelected GetSelected;
  


        public void SetList<T>(List<T> list,AdapterView view)
        {
            adapters = new List<AdapterView>();
            foreach (T data in list)
            {
                _view = (AdapterView)Activator.CreateInstance(view.GetType());
                _view.SetValue(data);
                _view.Draw(data);
                _view.GetSelected += ReciveEntity;
                adapters.Add(_view);
            }
        }

  

        public void ReciveEntity(object o)
        {
            GetSelectEntity?.Invoke(o);
        }
    }
}
