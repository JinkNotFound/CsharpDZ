using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bottle : Product
    {
        private float volume;

        public Bottle(double price, int place, string name, float volume) : base(price, place, name)
        {
            this.volume = volume;
        }

        public float Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "volume " + volume;
        }
    }
}
