using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Models.Serialization;
using Models.Models;

namespace Models
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Order> Orders { get; set; }
        [DataMember]
        public IEnumerable<Edition> Editions { get; set; }

        public DataModel()
        {
            Editions = new List<Edition>() { new Edition() {Author = "Rachel Clarke", Circulation = 200, Name  = "Dear Life", OrderId = 1, Scope = 500 } };
            Orders = new List<Order>() { new Order() { Id = 1, Status = OrderStatus.InProgress, CustomerName = "Emirova Alie", CustomerPhone = "+0630314247", OrderDate = DateTime.Now, Product = ProductType.Magazine} };
        }

        public static string DataPath = "publish.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
