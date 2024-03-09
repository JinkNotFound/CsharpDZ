using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        private double price;
        private int place;
        private string name;

        public Product(double price, int place, string name)
        {
            SetPrice(price); // Вызываем метод установки цены для проверки и установки значения
            this.place = place;
            this.name = name;
        }

        public double Price
        {
            get { return price; }
        }

        public void SetPrice(double price)
        {
            this.price = price < 0 ? 100 : price;
        }

        public int Place
        {
            get { return place; }
            set { place = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"Product{{price={price}, place={place}, name='{name}'}}";
        }
    }
}
