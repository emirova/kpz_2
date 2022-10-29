using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [DataContract]
    public class Edition
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public int Scope { get; set; }

        [DataMember]
        public int Circulation { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

}
