using System;

namespace Domain
{
    public class HotDrink : Bottle
    {
        private int temperature;

        public HotDrink(double price, int place, string name, float volume, int temperature) : base(price, place, name, volume)
        {
            this.temperature = temperature;
        }

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " temperature=" + temperature;
        }
    }
}
