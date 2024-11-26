using System.Collections.Generic;
using System;

namespace MyTransportApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Car Car { get; set; }
        public Driver Driver { get; set; }
        public DateTime OrderDate { get; set; }
        public List<CargoItem> CargoItems { get; set; }

        public Order()
        {
            CargoItems = new List<CargoItem>();
        }
    }
}

