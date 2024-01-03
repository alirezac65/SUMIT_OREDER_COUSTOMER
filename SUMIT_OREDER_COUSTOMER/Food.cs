using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMIT_OREDER_COUSTOMER
{
    internal class Food
    {
        int code_Food;
        string name_Food;
        int price_Food;
        public Goruping_Food G_F=new Goruping_Food();
        public int Code_Food
        {
            set { code_Food = value; }
            get { return code_Food; }
        }
        public string Name_Food
        {
            set { name_Food = value; }
            get { return name_Food; }
        }
        public int Price_Food
        {
            set { price_Food = value; }
            get { return price_Food; }
        }
    }
}
