using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public ProductType Product { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string CustomerPhone { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public OrderStatus Status{ get; set; }
    }

    [DataContract]
    public enum OrderStatus
    {
        [EnumMember]
        New,

        [EnumMember]
        InProgress,

        [EnumMember]
        Finished
    }

    [DataContract]
    public enum ProductType
    {
        [EnumMember]
        Book,

        [EnumMember]
        Magazine,

        [EnumMember]
        Catalog,

        [EnumMember]
        Brochure,

        [EnumMember]
        Card
    }
}
