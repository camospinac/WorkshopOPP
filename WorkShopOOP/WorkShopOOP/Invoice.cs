using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopOOP
{
    public class Invoice : IPay
    {
        private string _products;

        public Invoice(Product)
        {
              //finish invoice class with private fields!!!!
        }

        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
