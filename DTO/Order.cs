using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        private String id;
        private String name;
        private int price;
        private int count;
        private int total;

        public Order() { }

        public Order(string id, string name, int price, int count, int total)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.count = count;
            this.total = total;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public int Total { get => count * price; set => total = value; }
    }
}
