
using System.Collections.Generic;

namespace observerApp.classes
{
    public class Subject
    {
        private static Subject _sub;
        private List<IObserver> _listaObserver = new List<IObserver>();
        private string _state;

        private Subject() {}

        public static Subject GetSubject()
        {
            if(_sub == null)
                _sub = new Subject();
            return _sub;
        }

        public void add(IObserver obs)
        {
            _listaObserver.Add(obs);
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
            execute();
        }

        private void execute()
        {
            foreach(IObserver obs in _listaObserver)
            {
                obs.update();
            }
        }


    }
}