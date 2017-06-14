using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Takepayment
    {
        static public IPayment FactoryMethod(string choose)
        {
            IPayment paymenttype = null;
            if(choose=="Check")
            {
                paymenttype = new Check();
            }
            if(choose=="Cash")
            {
                paymenttype = new Cash();
            }
            if(choose=="CreditCard")
            {
                paymenttype = new CreditCard();
            }
            return paymenttype; 
        }
    }
}
