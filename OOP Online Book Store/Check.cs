﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Check : IPayment
    {
        public string paymentconfirmandtype()
        {
           return "Payment is success with check and cart is confirm";
        }
    }
}
