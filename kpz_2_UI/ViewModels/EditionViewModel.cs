using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz_2_UI.ViewModels
{
    public class EditionViewModel : ViewModelBase
    {
        private int _orderId;
        public int OrderId
        {
            get 
            {
                return _orderId; 
            }
            set
            {
                _orderId = value;
                OnPropertyChanged("OrderId");
            }
        }

        private int _scope;
        public int Scope
        {
            get { return _scope; }
            set
            {
                _scope = value;
                OnPropertyChanged("Scope");
            }
        }

        private int _circulation;
        public int Circulation
        {
            get { return _circulation; }
            set
            {
                _circulation = value;
                OnPropertyChanged("Circulation");
            }
        }

        private string _author;
        public string Author
        {

            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("Author");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
