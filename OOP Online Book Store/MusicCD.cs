﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class MusicCD : Product
    {
        private string singer;
        private string type;
        public MusicCD()
        {
        }
        public MusicCD(int _Id,string _Name, double  _Price,string _Singer, string _Type)
        {
            base.Id = _Id;
            base.Name = _Name;
            base.Price = _Price;
            singer = _Singer;
            type = _Type;
        }
        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
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
            string[] musicCD = new string[5];
            musicCD[0] = base.Id.ToString();
            musicCD[1] = base.Name;
            musicCD[2] = base.Price.ToString();
            musicCD[3] = singer;
            musicCD[4] = type;            
            return musicCD;
        }
    }
}
