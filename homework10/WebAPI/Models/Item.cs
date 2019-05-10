using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWebAPI.Models
{
    public class Item
    {
        public long Id { get; set;}
        public string Name { get; set; }
        public double Price { get; set; }
        public string Client { get; set; }

        public Item()
        {

        }
        public Item(long id,string name,double price,string client)
        {
            Id = id;
            Name = name;
            Price = price;
            Client = client;
        }
    }
}
