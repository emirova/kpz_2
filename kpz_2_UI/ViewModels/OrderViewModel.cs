using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz_2_UI.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private ProductType _product;
        public ProductType Product
        {
            get 
            { 
                return _product; 
            }
            set
            {
                _product = value;
                OnPropertyChanged("Product");
            }

        }

        private string _cName;
        public string CustomerName
        {
            get
            {
                return _cName;
            }
            set
            {
                _cName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        private string _cPhone;
        public string CustomerPhone
        {
            get
            {
                return _cPhone; 
            }
            set
            {
                _cPhone = value;
                OnPropertyChanged("CustomerPhone");
            }
        }

        private DateTime _orderDate;
        public DateTime OrderDate
        {
            get
            {
                return _orderDate; 
            }
            set
            {
                _orderDate = value;
                OnPropertyChanged("OrderDate");
            }
        }

        private OrderStatus _status;
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }
}
