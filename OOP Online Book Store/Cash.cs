﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Cash : IPayment
    {
        public string paymentconfirmandtype()
        {
            return "Payment is success with cash and cart is confirm";
        }
    }
}
