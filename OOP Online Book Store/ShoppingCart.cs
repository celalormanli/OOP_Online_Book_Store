using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class ShoppingCart
    {
        private long CustomerID;
        private List<ItemToPurchase> itemsToPurchase = new List<ItemToPurchase>();
        private double paymentAmount;
        private string paymentType;

        public long CustomerID1
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID = value;
            }
        }

        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }

            set
            {
                paymentAmount = value;
            }
        }

        public string PaymentType
        {
            get
            {
                return paymentType;
            }

            set
            {
                paymentType = value;
            }
        }

        internal List<ItemToPurchase> ItemsToPurchase
        {
            get
            {
                return itemsToPurchase;
            }

            set
            {
                itemsToPurchase = value;
            }
        }
        public string[] printProducts(int i)
        {
            string[] preportiesProduct = new string[4];
            preportiesProduct[0] = itemsToPurchase[i].Product.Id.ToString();
            preportiesProduct[1] = itemsToPurchase[i].Product.Name.ToString();
            preportiesProduct[2] =itemsToPurchase[i].Product.Price.ToString();
            preportiesProduct[3] = itemsToPurchase[i].Quantity.ToString();
            return preportiesProduct;
        }
        public void addProduct(Product prod,int quan)
        {
            int flag = 0;
            for(int i=0;i<itemsToPurchase.Count;i++)
            {
                if(prod.Name==itemsToPurchase[i].Product.Name)
                {
                    itemsToPurchase[i].Quantity += quan;
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
            {
            ItemToPurchase itemm = new ItemToPurchase();
            itemm.Product = prod;
            itemm.Quantity = quan;
            itemsToPurchase.Add(itemm);
            }
            

        }
        public void removeProduct(int indexdelete)
        {
            ItemsToPurchase.RemoveAt(indexdelete);
        }
        public string placeOrder()
        {
            itemsToPurchase.Clear();
            return "Prepared order.";
           
        }
        public string cancelOrder()
        {
            return "Canceled Order.";
        }
        public string sendInvoicebySMS()
        {
            return "Sent Invoice by SMS.";
        }
        public string sendInvoidcebyEmail()
        {
            return "Sent Invoice by Email.";
        }
        public double calculateTotalPrice()
        {
            double total = 0;
            for(int i=0;i<itemsToPurchase.Count;i++)
            {
                total += itemsToPurchase[i].Product.Price * itemsToPurchase[i].Quantity;
            }
            return total;
        }
    }
}
