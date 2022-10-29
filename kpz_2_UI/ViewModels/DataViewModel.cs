using Models.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace kpz_2_UI.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            OrderFinishedCommand = new Command(FinishOrder);
            OrderInProgressCommand = new Command(InProgressOrder);
            OrderNewCommand = new Command(NewOrder);
        }

        private string _visibleControl = "Orders";
        public string VisibleControl
        {
            get { return _visibleControl; }
            set 
            {
                _visibleControl = value; 
                OnPropertyChanged("VisibleControl");
            }
        }

        private OrderViewModel _selectedOrder;
        public OrderViewModel SelectedOrder 
        { 
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        public ICommand SetControlVisibility { get; set; }
        public ICommand OrderFinishedCommand { get; set; }
        public ICommand OrderInProgressCommand { get; set; }
        public ICommand OrderNewCommand { get; set; }
        public void FinishOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.Finished;
        }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public void InProgressOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.InProgress;
        }

        public ICommand OrderNewCommand { get; set; }

        public void NewOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.New;
        }

        private ObservableCollection<OrderViewModel> _orders;

        public ObservableCollection<OrderViewModel> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }
        private ObservableCollection<EditionViewModel> _editions;

        public ObservableCollection<EditionViewModel> Editions
        {
            get { return _editions; }
            set
            {
                _editions = value;
                OnPropertyChanged("Orders");
            }
        }
    }
}
