using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;

namespace Service
{
    public class VendingMachine
    {
        private Holder holder;
        private CoinDispenser coinDispenser;
        private Display display;
        private List<Product> productList;

        public VendingMachine(Holder holder, CoinDispenser coinDispenser, Display display, List<Product> productList)
        {
            this.holder = holder;
            this.coinDispenser = coinDispenser;
            this.display = display;
            this.productList = productList;
        }

        public Holder GetHolder()
        {
            return holder;
        }

        public CoinDispenser GetCoinDispenser()
        {
            return coinDispenser;
        }

        public Display GetDisplay()
        {
            return display;
        }

        public List<Product> GetProductList()
        {
            return productList;
        }
    }
}
