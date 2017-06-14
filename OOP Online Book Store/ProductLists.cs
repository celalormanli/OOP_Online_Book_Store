using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class ProductLists
    {
        private static ProductLists Lists;
        public List<Product> MusicCDlist = new List<Product>();
        public List<Product> Boklist = new List<Product>();
        public List<Product> Magazinelist = new List<Product>();
        private ProductLists()
        {

        }
        public static ProductLists Createtor()
        {
            if (Lists == null)
            {
                Lists = new ProductLists();
            }
            return Lists;
        }
    }
}
