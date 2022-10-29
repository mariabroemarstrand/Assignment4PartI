using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Required { get; set; }    
        public string OrderDetails { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
    }
}





