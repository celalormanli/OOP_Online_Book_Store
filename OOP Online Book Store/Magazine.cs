using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Magazine : Product
    {
        private int issue;
        private string type;
        public Magazine()
        {

        }
        public Magazine(int _Id, string _Name, double _Price,int _Issue,string _Type)
        {
            base.Id = _Id;
            base.Name = _Name;
            base.Price = _Price;
            issue = _Issue;
            type = _Type;
        }
        public int Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }


        public override string[] printProperties()
        {
            string[] magazine = new string[5];
            magazine[0] = base.Id.ToString();
            magazine[1] = base.Name;
            magazine[2] = base.Price.ToString();
            magazine[3] = issue.ToString();
            magazine[4] = type;
            return magazine;
        }
    }
}
